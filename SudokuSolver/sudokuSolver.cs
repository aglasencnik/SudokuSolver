﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    public class sudokuSolver
    {
        int[] gridInput;

        public sudokuSolver(int[] data)
        {
            try
            {
                gridInput = data;
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void errorHandler(Exception ex)
        {
            try
            {
                if (MessageBox.Show("The application has encountered an unexpected error!" + Environment.NewLine + "Do you want to see more details?", "Error!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(1);
                }
                else
                {
                    Environment.Exit(1);
                }
            }
            catch
            {
                Environment.Exit(1);
            }
        }

        public void solve()
        {
            try
            {

            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }
    }
}
