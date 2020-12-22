using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace archi_Template
{
    public partial class Form1 : Form
    {
        //intial mips
        Dictionary<string, int> Register_Emutor_mips = new Dictionary<string, int>();
        Dictionary<uint, string> Memory_Emutor_mips = new Dictionary<uint, string>();
        int Program_Counter, instruvtion_size, i, automatic_counter;
        string[] Store_instruction;
        string k, l, m, n;



        // machine code:
        /*
1000:00000000011110110001000000100100
1004:00000000101000000010000000100000
1008:10001111101001110000000000000100
1012:00000000010000110100000000100010
1016:00000000100001010011000000100101
       */










        private void PiplineGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void MipsRegisterGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
      
        private void inializeBtn_Click(object sender, EventArgs e)
        {
            //initial grid

            GridRegister.Rows.Add(32);
            PiplineGridRegister.Rows.Add(4);
            MemoryGridView.Rows.Add(1500);
            PiplineGridRegister.Rows[0].Cells[0].Value = "IF/ID";
            PiplineGridRegister.Rows[1].Cells[0].Value = "ID/EX";
            PiplineGridRegister.Rows[2].Cells[0].Value = "EX/MEM";
            PiplineGridRegister.Rows[3].Cells[0].Value = "MEM/WB";
            //read instruction and store
            automatic_counter = 0;
            i = 0;
            Program_Counter = int.Parse(StartPc.Text);
            Store_instruction = UserCodeIns.Text.ToString().Split('\n');
            instruvtion_size = Store_instruction.Count();
            //store memory value
            for (int r = 0; r < 1500; r++)
            {
                MemoryGridView.Rows[r].Cells[0].Value = r ;
                MemoryGridView.Rows[r].Cells[1].Value = "99";
                Memory_Emutor_mips[(uint)r] = "99";
            }
            //store register value
            Register_Emutor_mips["$0"] = 0;
            GridRegister.Rows[0].Cells[0].Value = "$0";
            GridRegister.Rows[0].Cells[1].Value = Register_Emutor_mips["$0"];
            for (int r = 1; r < 32; r++)
            {
                Register_Emutor_mips[("$" + r)] = (int)(r + 100);
                GridRegister.Rows[r].Cells[0].Value = ("$" + r);
                GridRegister.Rows[r].Cells[1].Value = Register_Emutor_mips[("$" + r)];
            }
        }

     
        public string Excute_instruction(string ro)
        {
            string []tempArr = ro.Split(' ');
            int aluSrcResult, regDstResult, ALU_RESULT, DESTENATION;
            //check if i type or R type
            if (tempArr[5] == "100000" || tempArr[5] == "100010" || tempArr[5] == "100101" || tempArr[5] == "100100") {
                aluSrcResult = 0;
                regDstResult = 0;
            }
            else {
                aluSrcResult = 1;
                regDstResult = 1;
           }
            // make mux of regDst
            if (regDstResult == 0)
            {
                DESTENATION = Convert.ToInt32(tempArr[3], 2);
            }
            else
            {
                DESTENATION = int.Parse(tempArr[6]);
            }
            //make ALU
            if (tempArr[5] == "100010")
                ALU_RESULT= int.Parse(tempArr[1]) - int.Parse(tempArr[2]);
           else if (tempArr[5] == "100101")
                ALU_RESULT= int.Parse(tempArr[1]) | int.Parse(tempArr[2]);
           else  if (tempArr[5] == "100100")
                ALU_RESULT= int.Parse(tempArr[1]) & int.Parse(tempArr[2]);
            else 
            {
                if(aluSrcResult==0)
                ALU_RESULT= int.Parse(tempArr[1]) + int.Parse(tempArr[2]);
                else
                ALU_RESULT = int.Parse(tempArr[1]) + Convert.ToInt32(tempArr[4],2);
            }
          //return result
            return DESTENATION + " "+ALU_RESULT+" "+tempArr[0];
        }

        public string Fetch_ins(string RoRo)
        {
            string temp = RoRo.Substring(0, 4);
            int ro = (int.Parse(temp) + 4);
            string res = ro + " " + RoRo.Substring(5, 32);
            return res;
        }
        public string Decode_instruction(string ro)
        {
            string op_value = ro.Substring(5, 6), rs_value = ro.Substring(11, 5), rt_value = ro.Substring(16, 5), rd_value = ro.Substring(21, 5), offset_value = ro.Substring(21, 16), function_code = ro.Substring(31, 6);
            return op_value + " " + Register_Emutor_mips[("$" + Convert.ToInt32(rs_value, 2))] + " " + Register_Emutor_mips[("$" + Convert.ToInt32(rt_value, 2))] + " " + rd_value + " " + offset_value + " " + function_code + " " + Convert.ToInt32(rt_value, 2);
        }


        public string Memory_instruction(string ro)
        {
            string[] roro = ro.Split(' ');
            //initial store result of alu
            string val = roro[1];
            //check if lw till load from memory in val till change value it
            if (!roro[2].Equals("000000"))    val = Memory_Emutor_mips[uint.Parse(roro[1])];
            return roro[0]+" "+val;
        }
        public void WB_instruction(string ro)
        {
            string[] roro = ro.Split(' ');
            string s = ("$" + roro[0]);
            // store result of alu in mips Register and Grid
            Register_Emutor_mips[s] = int.Parse(roro[1]);
            GridRegister.Rows[int.Parse(roro[0])].Cells[1].Value = Register_Emutor_mips[s];
        }
        private void runCycleBtn_Click(object sender, EventArgs e)
        {
            ++automatic_counter;
            if (automatic_counter >= 5 && automatic_counter <= instruvtion_size+4)
            {
                 WB_instruction(n);
            }
            if (automatic_counter >= 4 && automatic_counter <= instruvtion_size+3)
            {
                n = Memory_instruction(m);
                PiplineGridRegister.Rows[3].Cells[1].Value = n;
            }
            if (automatic_counter >= 3 && automatic_counter <= instruvtion_size+2)
            {
                m = Excute_instruction(l);
                PiplineGridRegister.Rows[2].Cells[1].Value = m;
            }
            if (automatic_counter >= 2 && automatic_counter <= instruvtion_size+1)
            {
               l= Decode_instruction(k);
               PiplineGridRegister.Rows[1].Cells[1].Value = l;
            }
                if (automatic_counter >= 1 && automatic_counter <=instruvtion_size)
            {
                Program_Counter += 4;
                StartPc.Text = Program_Counter.ToString();
                k = Fetch_ins(Store_instruction[i]);
                PiplineGridRegister.Rows[0].Cells[1].Value = k;
                i++;
            }
        }
    }
}
