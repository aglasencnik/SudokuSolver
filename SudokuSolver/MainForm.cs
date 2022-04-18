using System.Collections;
using System.Linq;

namespace SudokuSolver
{
    public partial class MainForm : Form
    {
        #region Decleration of variables

        private int numOfInputs;
        private bool tbx_1_used;
        private bool tbx_2_used;
        private bool tbx_3_used;
        private bool tbx_4_used;
        private bool tbx_5_used;
        private bool tbx_6_used;
        private bool tbx_7_used;
        private bool tbx_8_used;
        private bool tbx_9_used;
        private bool tbx_10_used;
        private bool tbx_11_used;
        private bool tbx_12_used;
        private bool tbx_13_used;
        private bool tbx_14_used;
        private bool tbx_15_used;
        private bool tbx_16_used;
        private bool tbx_17_used;
        private bool tbx_18_used;
        private bool tbx_19_used;
        private bool tbx_20_used;
        private bool tbx_21_used;
        private bool tbx_22_used;
        private bool tbx_23_used;
        private bool tbx_24_used;
        private bool tbx_25_used;
        private bool tbx_26_used;
        private bool tbx_27_used;
        private bool tbx_28_used;
        private bool tbx_29_used;
        private bool tbx_30_used;
        private bool tbx_31_used;
        private bool tbx_32_used;
        private bool tbx_33_used;
        private bool tbx_34_used;
        private bool tbx_35_used;
        private bool tbx_36_used;
        private bool tbx_37_used;
        private bool tbx_38_used;
        private bool tbx_39_used;
        private bool tbx_40_used;
        private bool tbx_41_used;
        private bool tbx_42_used;
        private bool tbx_43_used;
        private bool tbx_44_used;
        private bool tbx_45_used;
        private bool tbx_46_used;
        private bool tbx_47_used;
        private bool tbx_48_used;
        private bool tbx_49_used;
        private bool tbx_50_used;
        private bool tbx_51_used;
        private bool tbx_52_used;
        private bool tbx_53_used;
        private bool tbx_54_used;
        private bool tbx_55_used;
        private bool tbx_56_used;
        private bool tbx_57_used;
        private bool tbx_58_used;
        private bool tbx_59_used;
        private bool tbx_60_used;
        private bool tbx_61_used;
        private bool tbx_62_used;
        private bool tbx_63_used;
        private bool tbx_64_used;
        private bool tbx_65_used;
        private bool tbx_66_used;
        private bool tbx_67_used;
        private bool tbx_68_used;
        private bool tbx_69_used;
        private bool tbx_70_used;
        private bool tbx_71_used;
        private bool tbx_72_used;
        private bool tbx_73_used;
        private bool tbx_74_used;
        private bool tbx_75_used;
        private bool tbx_76_used;
        private bool tbx_77_used;
        private bool tbx_78_used;
        private bool tbx_79_used;
        private bool tbx_80_used;
        private bool tbx_81_used;

        private int tbx_1_number;
        private int tbx_2_number;
        private int tbx_3_number;
        private int tbx_4_number;
        private int tbx_5_number;
        private int tbx_6_number;
        private int tbx_7_number;
        private int tbx_8_number;
        private int tbx_9_number;
        private int tbx_10_number;
        private int tbx_11_number;
        private int tbx_12_number;
        private int tbx_13_number;
        private int tbx_14_number;
        private int tbx_15_number;
        private int tbx_16_number;
        private int tbx_17_number;
        private int tbx_18_number;
        private int tbx_19_number;
        private int tbx_20_number;
        private int tbx_21_number;
        private int tbx_22_number;
        private int tbx_23_number;
        private int tbx_24_number;
        private int tbx_25_number;
        private int tbx_26_number;
        private int tbx_27_number;
        private int tbx_28_number;
        private int tbx_29_number;
        private int tbx_30_number;
        private int tbx_31_number;
        private int tbx_32_number;
        private int tbx_33_number;
        private int tbx_34_number;
        private int tbx_35_number;
        private int tbx_36_number;
        private int tbx_37_number;
        private int tbx_38_number;
        private int tbx_39_number;
        private int tbx_40_number;
        private int tbx_41_number;
        private int tbx_42_number;
        private int tbx_43_number;
        private int tbx_44_number;
        private int tbx_45_number;
        private int tbx_46_number;
        private int tbx_47_number;
        private int tbx_48_number;
        private int tbx_49_number;
        private int tbx_50_number;
        private int tbx_51_number;
        private int tbx_52_number;
        private int tbx_53_number;
        private int tbx_54_number;
        private int tbx_55_number;
        private int tbx_56_number;
        private int tbx_57_number;
        private int tbx_58_number;
        private int tbx_59_number;
        private int tbx_60_number;
        private int tbx_61_number;
        private int tbx_62_number;
        private int tbx_63_number;
        private int tbx_64_number;
        private int tbx_65_number;
        private int tbx_66_number;
        private int tbx_67_number;
        private int tbx_68_number;
        private int tbx_69_number;
        private int tbx_70_number;
        private int tbx_71_number;
        private int tbx_72_number;
        private int tbx_73_number;
        private int tbx_74_number;
        private int tbx_75_number;
        private int tbx_76_number;
        private int tbx_77_number;
        private int tbx_78_number;
        private int tbx_79_number;
        private int tbx_80_number;
        private int tbx_81_number;

        private sudokuGrid[] sudokuGrids;
        private int numberOfResults;
        private int currentResultIndex;

        #endregion


        public MainForm()
        {
            try
            {
                InitializeComponent();
                resetCtor();
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void resetCtor()
        {
            try
            {
                numOfInputs = 0;
                numberOfResults = 0;
                currentResultIndex = 0;
                tbx_1_used = false;
                tbx_2_used = false;
                tbx_3_used = false;
                tbx_4_used = false;
                tbx_5_used = false;
                tbx_6_used = false;
                tbx_7_used = false;
                tbx_8_used = false;
                tbx_9_used = false;
                tbx_10_used = false;
                tbx_11_used = false;
                tbx_12_used = false;
                tbx_13_used = false;
                tbx_14_used = false;
                tbx_15_used = false;
                tbx_16_used = false;
                tbx_17_used = false;
                tbx_18_used = false;
                tbx_19_used = false;
                tbx_20_used = false;
                tbx_21_used = false;
                tbx_22_used = false;
                tbx_23_used = false;
                tbx_24_used = false;
                tbx_25_used = false;
                tbx_26_used = false;
                tbx_27_used = false;
                tbx_28_used = false;
                tbx_29_used = false;
                tbx_30_used = false;
                tbx_31_used = false;
                tbx_32_used = false;
                tbx_33_used = false;
                tbx_34_used = false;
                tbx_35_used = false;
                tbx_36_used = false;
                tbx_37_used = false;
                tbx_38_used = false;
                tbx_39_used = false;
                tbx_40_used = false;
                tbx_41_used = false;
                tbx_42_used = false;
                tbx_43_used = false;
                tbx_44_used = false;
                tbx_45_used = false;
                tbx_46_used = false;
                tbx_47_used = false;
                tbx_48_used = false;
                tbx_49_used = false;
                tbx_50_used = false;
                tbx_51_used = false;
                tbx_52_used = false;
                tbx_53_used = false;
                tbx_54_used = false;
                tbx_55_used = false;
                tbx_56_used = false;
                tbx_57_used = false;
                tbx_58_used = false;
                tbx_59_used = false;
                tbx_60_used = false;
                tbx_61_used = false;
                tbx_62_used = false;
                tbx_63_used = false;
                tbx_64_used = false;
                tbx_65_used = false;
                tbx_66_used = false;
                tbx_67_used = false;
                tbx_68_used = false;
                tbx_69_used = false;
                tbx_70_used = false;
                tbx_71_used = false;
                tbx_72_used = false;
                tbx_73_used = false;
                tbx_74_used = false;
                tbx_75_used = false;
                tbx_76_used = false;
                tbx_77_used = false;
                tbx_78_used = false;
                tbx_79_used = false;
                tbx_80_used = false;
                tbx_81_used = false;

                tbx_1_number = 0;
                tbx_2_number = 0;
                tbx_3_number = 0;
                tbx_4_number = 0;
                tbx_5_number = 0;
                tbx_6_number = 0;
                tbx_7_number = 0;
                tbx_8_number = 0;
                tbx_9_number = 0;
                tbx_10_number = 0;
                tbx_11_number = 0;
                tbx_12_number = 0;
                tbx_13_number = 0;
                tbx_14_number = 0;
                tbx_15_number = 0;
                tbx_16_number = 0;
                tbx_17_number = 0;
                tbx_18_number = 0;
                tbx_19_number = 0;
                tbx_20_number = 0;
                tbx_21_number = 0;
                tbx_22_number = 0;
                tbx_23_number = 0;
                tbx_24_number = 0;
                tbx_25_number = 0;
                tbx_26_number = 0;
                tbx_27_number = 0;
                tbx_28_number = 0;
                tbx_29_number = 0;
                tbx_30_number = 0;
                tbx_31_number = 0;
                tbx_32_number = 0;
                tbx_33_number = 0;
                tbx_34_number = 0;
                tbx_35_number = 0;
                tbx_36_number = 0;
                tbx_37_number = 0;
                tbx_38_number = 0;
                tbx_39_number = 0;
                tbx_40_number = 0;
                tbx_41_number = 0;
                tbx_42_number = 0;
                tbx_43_number = 0;
                tbx_44_number = 0;
                tbx_45_number = 0;
                tbx_46_number = 0;
                tbx_47_number = 0;
                tbx_48_number = 0;
                tbx_49_number = 0;
                tbx_50_number = 0;
                tbx_51_number = 0;
                tbx_52_number = 0;
                tbx_53_number = 0;
                tbx_54_number = 0;
                tbx_55_number = 0;
                tbx_56_number = 0;
                tbx_57_number = 0;
                tbx_58_number = 0;
                tbx_59_number = 0;
                tbx_60_number = 0;
                tbx_61_number = 0;
                tbx_62_number = 0;
                tbx_63_number = 0;
                tbx_64_number = 0;
                tbx_65_number = 0;
                tbx_66_number = 0;
                tbx_67_number = 0;
                tbx_68_number = 0;
                tbx_69_number = 0;
                tbx_70_number = 0;
                tbx_71_number = 0;
                tbx_72_number = 0;
                tbx_73_number = 0;
                tbx_74_number = 0;
                tbx_75_number = 0;
                tbx_76_number = 0;
                tbx_77_number = 0;
                tbx_78_number = 0;
                tbx_79_number = 0;
                tbx_80_number = 0;
                tbx_81_number = 0;
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                pbx_loading.Visible = false;
                resetLoad();
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void resetLoad()
        {
            try
            {
                btn_previous.Enabled = false;
                btn_next.Enabled = false;
                btn_previous.Visible = false;
                btn_next.Visible = false;
                lbl_numText.Visible = false;
                lbl_numOfResults.Visible = false;
                lbl_labelResultPage.Visible = false;
                lbl_currentPage.Visible = false;
                this.ActiveControl = lbl_version;
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

        private void btn_about_Click(object sender, EventArgs e)
        {
            try
            {
                this.ActiveControl = lbl_version;
                MessageBox.Show("Amadej Glasenènik, 2022" + Environment.NewLine + "aglasencnik.com", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        #region TextBox KeyPress methods
        //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        private void tbx_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_3_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_4_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_5_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_6_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_7_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_8_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_9_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_10_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_11_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_12_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_13_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_14_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_15_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_16_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_17_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_18_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_19_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_20_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_21_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_22_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_23_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_24_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_25_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_26_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_27_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_28_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_29_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_30_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_31_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_32_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_33_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_34_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_35_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_36_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_37_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_38_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_39_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_40_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_41_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_42_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_43_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_44_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_45_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_46_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_47_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_48_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_49_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_50_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_51_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_52_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_53_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_54_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_55_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_56_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_57_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_58_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_59_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_60_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_61_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_62_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_63_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_64_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_65_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_66_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_67_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_68_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_69_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_70_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_71_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_72_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_73_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_74_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_75_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_76_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_77_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_78_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_79_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_80_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_81_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }




        #endregion

        private void btn_solve_Click(object sender, EventArgs e)
        {
            try
            {
                this.ActiveControl = lbl_version;
                if (numOfInputs >= 10)
                {
                    pbx_loading.Visible = true;
                    get_tbx_variables();

                    if (checkIfReal())
                    {
                        btn_solve.Enabled = false;
                        disable_tbx();
                        set_tbx_color();
                        sudokuSolver solver = new sudokuSolver(serializeGrid());
                        sudokuGrids = solver.solve();
                        btn_next.Visible = true;
                        btn_previous.Visible = true;
                        lbl_currentPage.Visible = true;
                        lbl_numOfResults.Visible = true;
                        lbl_numText.Visible = true;
                        lbl_labelResultPage.Visible = true;
                        numberOfResults = sudokuGrids.Length;
                        lbl_numOfResults.Text = (numberOfResults >= 1 ? ""+numberOfResults : "0");
                        int page = currentResultIndex + 1;
                        lbl_currentPage.Text = "" + page;
                        btn_next.Enabled = (numberOfResults >= 2 ? true : false);
                        displayResult(currentResultIndex);
                    }
                    else
                    {
                        MessageBox.Show("Sudoku entered is not real!", "Sudoku not real!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    pbx_loading.Visible = false;
                }
                else
                {
                    MessageBox.Show("You haven't entered the minimum of 10 numbers." + Environment.NewLine + "You entered: " + numOfInputs + " numbers!", "Insufficient numbers!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void disable_tbx()
        {
            try
            {
                tbx_1.ReadOnly = true;
                tbx_2.ReadOnly = true;
                tbx_3.ReadOnly = true;
                tbx_4.ReadOnly = true;
                tbx_5.ReadOnly = true;
                tbx_6.ReadOnly = true;
                tbx_7.ReadOnly = true;
                tbx_8.ReadOnly = true;
                tbx_9.ReadOnly = true;
                tbx_10.ReadOnly = true;
                tbx_11.ReadOnly = true;
                tbx_12.ReadOnly = true;
                tbx_13.ReadOnly = true;
                tbx_14.ReadOnly = true;
                tbx_15.ReadOnly = true;
                tbx_16.ReadOnly = true;
                tbx_17.ReadOnly = true;
                tbx_18.ReadOnly = true;
                tbx_19.ReadOnly = true;
                tbx_20.ReadOnly = true;
                tbx_21.ReadOnly = true;
                tbx_22.ReadOnly = true;
                tbx_23.ReadOnly = true;
                tbx_24.ReadOnly = true;
                tbx_25.ReadOnly = true;
                tbx_26.ReadOnly = true;
                tbx_27.ReadOnly = true;
                tbx_28.ReadOnly = true;
                tbx_29.ReadOnly = true;
                tbx_30.ReadOnly = true;
                tbx_31.ReadOnly = true;
                tbx_32.ReadOnly = true;
                tbx_33.ReadOnly = true;
                tbx_34.ReadOnly = true;
                tbx_35.ReadOnly = true;
                tbx_36.ReadOnly = true;
                tbx_37.ReadOnly = true;
                tbx_38.ReadOnly = true;
                tbx_39.ReadOnly = true;
                tbx_40.ReadOnly = true;
                tbx_41.ReadOnly = true;
                tbx_42.ReadOnly = true;
                tbx_43.ReadOnly = true;
                tbx_44.ReadOnly = true;
                tbx_45.ReadOnly = true;
                tbx_46.ReadOnly = true;
                tbx_47.ReadOnly = true;
                tbx_48.ReadOnly = true;
                tbx_49.ReadOnly = true;
                tbx_50.ReadOnly = true;
                tbx_51.ReadOnly = true;
                tbx_52.ReadOnly = true;
                tbx_53.ReadOnly = true;
                tbx_54.ReadOnly = true;
                tbx_55.ReadOnly = true;
                tbx_56.ReadOnly = true;
                tbx_57.ReadOnly = true;
                tbx_58.ReadOnly = true;
                tbx_59.ReadOnly = true;
                tbx_60.ReadOnly = true;
                tbx_61.ReadOnly = true;
                tbx_62.ReadOnly = true;
                tbx_63.ReadOnly = true;
                tbx_64.ReadOnly = true;
                tbx_65.ReadOnly = true;
                tbx_66.ReadOnly = true;
                tbx_67.ReadOnly = true;
                tbx_68.ReadOnly = true;
                tbx_69.ReadOnly = true;
                tbx_70.ReadOnly = true;
                tbx_71.ReadOnly = true;
                tbx_72.ReadOnly = true;
                tbx_73.ReadOnly = true;
                tbx_74.ReadOnly = true;
                tbx_75.ReadOnly = true;
                tbx_76.ReadOnly = true;
                tbx_77.ReadOnly = true;
                tbx_78.ReadOnly = true;
                tbx_79.ReadOnly = true;
                tbx_80.ReadOnly = true;
                tbx_81.ReadOnly = true;
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void get_tbx_variables()
        {
            try
            {
                tbx_1_number = (tbx_1.Text != "" ? int.Parse(tbx_1.Text) : 0);
                tbx_2_number = (tbx_2.Text != "" ? int.Parse(tbx_2.Text) : 0);
                tbx_3_number = (tbx_3.Text != "" ? int.Parse(tbx_3.Text) : 0);
                tbx_4_number = (tbx_4.Text != "" ? int.Parse(tbx_4.Text) : 0);
                tbx_5_number = (tbx_5.Text != "" ? int.Parse(tbx_5.Text) : 0);
                tbx_6_number = (tbx_6.Text != "" ? int.Parse(tbx_6.Text) : 0);
                tbx_7_number = (tbx_7.Text != "" ? int.Parse(tbx_7.Text) : 0);
                tbx_8_number = (tbx_8.Text != "" ? int.Parse(tbx_8.Text) : 0);
                tbx_9_number = (tbx_9.Text != "" ? int.Parse(tbx_9.Text) : 0);
                tbx_10_number = (tbx_10.Text != "" ? int.Parse(tbx_10.Text) : 0);
                tbx_11_number = (tbx_11.Text != "" ? int.Parse(tbx_11.Text) : 0);
                tbx_12_number = (tbx_12.Text != "" ? int.Parse(tbx_12.Text) : 0);
                tbx_13_number = (tbx_13.Text != "" ? int.Parse(tbx_13.Text) : 0);
                tbx_14_number = (tbx_14.Text != "" ? int.Parse(tbx_14.Text) : 0);
                tbx_15_number = (tbx_15.Text != "" ? int.Parse(tbx_15.Text) : 0);
                tbx_16_number = (tbx_16.Text != "" ? int.Parse(tbx_16.Text) : 0);
                tbx_17_number = (tbx_17.Text != "" ? int.Parse(tbx_17.Text) : 0);
                tbx_18_number = (tbx_18.Text != "" ? int.Parse(tbx_18.Text) : 0);
                tbx_19_number = (tbx_19.Text != "" ? int.Parse(tbx_19.Text) : 0);
                tbx_20_number = (tbx_20.Text != "" ? int.Parse(tbx_20.Text) : 0);
                tbx_21_number = (tbx_21.Text != "" ? int.Parse(tbx_21.Text) : 0);
                tbx_22_number = (tbx_22.Text != "" ? int.Parse(tbx_22.Text) : 0);
                tbx_23_number = (tbx_23.Text != "" ? int.Parse(tbx_23.Text) : 0);
                tbx_24_number = (tbx_24.Text != "" ? int.Parse(tbx_24.Text) : 0);
                tbx_25_number = (tbx_25.Text != "" ? int.Parse(tbx_25.Text) : 0);
                tbx_26_number = (tbx_26.Text != "" ? int.Parse(tbx_26.Text) : 0);
                tbx_27_number = (tbx_27.Text != "" ? int.Parse(tbx_27.Text) : 0);
                tbx_28_number = (tbx_28.Text != "" ? int.Parse(tbx_28.Text) : 0);
                tbx_29_number = (tbx_29.Text != "" ? int.Parse(tbx_29.Text) : 0);
                tbx_30_number = (tbx_30.Text != "" ? int.Parse(tbx_30.Text) : 0);
                tbx_31_number = (tbx_31.Text != "" ? int.Parse(tbx_31.Text) : 0);
                tbx_32_number = (tbx_32.Text != "" ? int.Parse(tbx_32.Text) : 0);
                tbx_33_number = (tbx_33.Text != "" ? int.Parse(tbx_33.Text) : 0);
                tbx_34_number = (tbx_34.Text != "" ? int.Parse(tbx_34.Text) : 0);
                tbx_35_number = (tbx_35.Text != "" ? int.Parse(tbx_35.Text) : 0);
                tbx_36_number = (tbx_36.Text != "" ? int.Parse(tbx_36.Text) : 0);
                tbx_37_number = (tbx_37.Text != "" ? int.Parse(tbx_37.Text) : 0);
                tbx_38_number = (tbx_38.Text != "" ? int.Parse(tbx_38.Text) : 0);
                tbx_39_number = (tbx_39.Text != "" ? int.Parse(tbx_39.Text) : 0);
                tbx_40_number = (tbx_40.Text != "" ? int.Parse(tbx_40.Text) : 0);
                tbx_41_number = (tbx_41.Text != "" ? int.Parse(tbx_41.Text) : 0);
                tbx_42_number = (tbx_42.Text != "" ? int.Parse(tbx_42.Text) : 0);
                tbx_43_number = (tbx_43.Text != "" ? int.Parse(tbx_43.Text) : 0);
                tbx_44_number = (tbx_44.Text != "" ? int.Parse(tbx_44.Text) : 0);
                tbx_45_number = (tbx_45.Text != "" ? int.Parse(tbx_45.Text) : 0);
                tbx_46_number = (tbx_46.Text != "" ? int.Parse(tbx_46.Text) : 0);
                tbx_47_number = (tbx_47.Text != "" ? int.Parse(tbx_47.Text) : 0);
                tbx_48_number = (tbx_48.Text != "" ? int.Parse(tbx_48.Text) : 0);
                tbx_49_number = (tbx_49.Text != "" ? int.Parse(tbx_49.Text) : 0);
                tbx_50_number = (tbx_50.Text != "" ? int.Parse(tbx_50.Text) : 0);
                tbx_51_number = (tbx_51.Text != "" ? int.Parse(tbx_51.Text) : 0);
                tbx_52_number = (tbx_52.Text != "" ? int.Parse(tbx_52.Text) : 0);
                tbx_53_number = (tbx_53.Text != "" ? int.Parse(tbx_53.Text) : 0);
                tbx_54_number = (tbx_54.Text != "" ? int.Parse(tbx_54.Text) : 0);
                tbx_55_number = (tbx_55.Text != "" ? int.Parse(tbx_55.Text) : 0);
                tbx_56_number = (tbx_56.Text != "" ? int.Parse(tbx_56.Text) : 0);
                tbx_57_number = (tbx_57.Text != "" ? int.Parse(tbx_57.Text) : 0);
                tbx_58_number = (tbx_58.Text != "" ? int.Parse(tbx_58.Text) : 0);
                tbx_59_number = (tbx_59.Text != "" ? int.Parse(tbx_59.Text) : 0);
                tbx_60_number = (tbx_60.Text != "" ? int.Parse(tbx_60.Text) : 0);
                tbx_61_number = (tbx_61.Text != "" ? int.Parse(tbx_61.Text) : 0);
                tbx_62_number = (tbx_62.Text != "" ? int.Parse(tbx_62.Text) : 0);
                tbx_63_number = (tbx_63.Text != "" ? int.Parse(tbx_63.Text) : 0);
                tbx_64_number = (tbx_64.Text != "" ? int.Parse(tbx_64.Text) : 0);
                tbx_65_number = (tbx_65.Text != "" ? int.Parse(tbx_65.Text) : 0);
                tbx_66_number = (tbx_66.Text != "" ? int.Parse(tbx_66.Text) : 0);
                tbx_67_number = (tbx_67.Text != "" ? int.Parse(tbx_67.Text) : 0);
                tbx_68_number = (tbx_68.Text != "" ? int.Parse(tbx_68.Text) : 0);
                tbx_69_number = (tbx_69.Text != "" ? int.Parse(tbx_69.Text) : 0);
                tbx_70_number = (tbx_70.Text != "" ? int.Parse(tbx_70.Text) : 0);
                tbx_71_number = (tbx_71.Text != "" ? int.Parse(tbx_71.Text) : 0);
                tbx_72_number = (tbx_72.Text != "" ? int.Parse(tbx_72.Text) : 0);
                tbx_73_number = (tbx_73.Text != "" ? int.Parse(tbx_73.Text) : 0);
                tbx_74_number = (tbx_74.Text != "" ? int.Parse(tbx_74.Text) : 0);
                tbx_75_number = (tbx_75.Text != "" ? int.Parse(tbx_75.Text) : 0);
                tbx_76_number = (tbx_76.Text != "" ? int.Parse(tbx_76.Text) : 0);
                tbx_77_number = (tbx_77.Text != "" ? int.Parse(tbx_77.Text) : 0);
                tbx_78_number = (tbx_78.Text != "" ? int.Parse(tbx_78.Text) : 0);
                tbx_79_number = (tbx_79.Text != "" ? int.Parse(tbx_79.Text) : 0);
                tbx_80_number = (tbx_80.Text != "" ? int.Parse(tbx_80.Text) : 0);
                tbx_81_number = (tbx_81.Text != "" ? int.Parse(tbx_81.Text) : 0);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void set_tbx_color()
        {
            try
            {
                if (tbx_1_number != 0)
                    tbx_1.ForeColor = Color.Red;
                else
                    tbx_1.ForeColor = Color.Blue;

                if (tbx_2_number != 0)
                    tbx_2.ForeColor = Color.Red;
                else
                    tbx_2.ForeColor = Color.Blue;

                if (tbx_3_number != 0)
                    tbx_3.ForeColor = Color.Red;
                else
                    tbx_3.ForeColor = Color.Blue;

                if (tbx_4_number != 0)
                    tbx_4.ForeColor = Color.Red;
                else
                    tbx_4.ForeColor = Color.Blue;

                if (tbx_5_number != 0)
                    tbx_5.ForeColor = Color.Red;
                else
                    tbx_5.ForeColor = Color.Blue;

                if (tbx_6_number != 0)
                    tbx_6.ForeColor = Color.Red;
                else
                    tbx_6.ForeColor = Color.Blue;

                if (tbx_7_number != 0)
                    tbx_7.ForeColor = Color.Red;
                else
                    tbx_7.ForeColor = Color.Blue;

                if (tbx_8_number != 0)
                    tbx_8.ForeColor = Color.Red;
                else
                    tbx_8.ForeColor = Color.Blue;

                if (tbx_9_number != 0)
                    tbx_9.ForeColor = Color.Red;
                else
                    tbx_9.ForeColor = Color.Blue;

                if (tbx_10_number != 0)
                    tbx_10.ForeColor = Color.Red;
                else
                    tbx_10.ForeColor = Color.Blue;

                if (tbx_11_number != 0)
                    tbx_11.ForeColor = Color.Red;
                else
                    tbx_11.ForeColor = Color.Blue;

                if (tbx_12_number != 0)
                    tbx_12.ForeColor = Color.Red;
                else
                    tbx_12.ForeColor = Color.Blue;

                if (tbx_13_number != 0)
                    tbx_13.ForeColor = Color.Red;
                else
                    tbx_13.ForeColor = Color.Blue;

                if (tbx_14_number != 0)
                    tbx_14.ForeColor = Color.Red;
                else
                    tbx_14.ForeColor = Color.Blue;

                if (tbx_15_number != 0)
                    tbx_15.ForeColor = Color.Red;
                else
                    tbx_15.ForeColor = Color.Blue;

                if (tbx_16_number != 0)
                    tbx_16.ForeColor = Color.Red;
                else
                    tbx_16.ForeColor = Color.Blue;

                if (tbx_17_number != 0)
                    tbx_17.ForeColor = Color.Red;
                else
                    tbx_17.ForeColor = Color.Blue;

                if (tbx_18_number != 0)
                    tbx_18.ForeColor = Color.Red;
                else
                    tbx_18.ForeColor = Color.Blue;

                if (tbx_19_number != 0)
                    tbx_19.ForeColor = Color.Red;
                else
                    tbx_19.ForeColor = Color.Blue;

                if (tbx_20_number != 0)
                    tbx_20.ForeColor = Color.Red;
                else
                    tbx_20.ForeColor = Color.Blue;

                if (tbx_21_number != 0)
                    tbx_21.ForeColor = Color.Red;
                else
                    tbx_21.ForeColor = Color.Blue;

                if (tbx_22_number != 0)
                    tbx_22.ForeColor = Color.Red;
                else
                    tbx_22.ForeColor = Color.Blue;

                if (tbx_23_number != 0)
                    tbx_23.ForeColor = Color.Red;
                else
                    tbx_23.ForeColor = Color.Blue;

                if (tbx_24_number != 0)
                    tbx_24.ForeColor = Color.Red;
                else
                    tbx_24.ForeColor = Color.Blue;

                if (tbx_25_number != 0)
                    tbx_25.ForeColor = Color.Red;
                else
                    tbx_25.ForeColor = Color.Blue;

                if (tbx_26_number != 0)
                    tbx_26.ForeColor = Color.Red;
                else
                    tbx_26.ForeColor = Color.Blue;

                if (tbx_27_number != 0)
                    tbx_27.ForeColor = Color.Red;
                else
                    tbx_27.ForeColor = Color.Blue;

                if (tbx_28_number != 0)
                    tbx_28.ForeColor = Color.Red;
                else
                    tbx_28.ForeColor = Color.Blue;

                if (tbx_29_number != 0)
                    tbx_29.ForeColor = Color.Red;
                else
                    tbx_29.ForeColor = Color.Blue;

                if (tbx_30_number != 0)
                    tbx_30.ForeColor = Color.Red;
                else
                    tbx_30.ForeColor = Color.Blue;

                if (tbx_31_number != 0)
                    tbx_31.ForeColor = Color.Red;
                else
                    tbx_31.ForeColor = Color.Blue;

                if (tbx_32_number != 0)
                    tbx_32.ForeColor = Color.Red;
                else
                    tbx_32.ForeColor = Color.Blue;

                if (tbx_33_number != 0)
                    tbx_33.ForeColor = Color.Red;
                else
                    tbx_33.ForeColor = Color.Blue;

                if (tbx_34_number != 0)
                    tbx_34.ForeColor = Color.Red;
                else
                    tbx_34.ForeColor = Color.Blue;

                if (tbx_35_number != 0)
                    tbx_35.ForeColor = Color.Red;
                else
                    tbx_35.ForeColor = Color.Blue;

                if (tbx_36_number != 0)
                    tbx_36.ForeColor = Color.Red;
                else
                    tbx_36.ForeColor = Color.Blue;

                if (tbx_37_number != 0)
                    tbx_37.ForeColor = Color.Red;
                else
                    tbx_37.ForeColor = Color.Blue;

                if (tbx_38_number != 0)
                    tbx_38.ForeColor = Color.Red;
                else
                    tbx_38.ForeColor = Color.Blue;

                if (tbx_39_number != 0)
                    tbx_39.ForeColor = Color.Red;
                else
                    tbx_39.ForeColor = Color.Blue;

                if (tbx_40_number != 0)
                    tbx_40.ForeColor = Color.Red;
                else
                    tbx_40.ForeColor = Color.Blue;

                if (tbx_41_number != 0)
                    tbx_41.ForeColor = Color.Red;
                else
                    tbx_41.ForeColor = Color.Blue;

                if (tbx_42_number != 0)
                    tbx_42.ForeColor = Color.Red;
                else
                    tbx_42.ForeColor = Color.Blue;

                if (tbx_43_number != 0)
                    tbx_43.ForeColor = Color.Red;
                else
                    tbx_43.ForeColor = Color.Blue;

                if (tbx_44_number != 0)
                    tbx_44.ForeColor = Color.Red;
                else
                    tbx_44.ForeColor = Color.Blue;

                if (tbx_45_number != 0)
                    tbx_45.ForeColor = Color.Red;
                else
                    tbx_45.ForeColor = Color.Blue;

                if (tbx_46_number != 0)
                    tbx_46.ForeColor = Color.Red;
                else
                    tbx_46.ForeColor = Color.Blue;

                if (tbx_47_number != 0)
                    tbx_47.ForeColor = Color.Red;
                else
                    tbx_47.ForeColor = Color.Blue;

                if (tbx_48_number != 0)
                    tbx_48.ForeColor = Color.Red;
                else
                    tbx_48.ForeColor = Color.Blue;

                if (tbx_49_number != 0)
                    tbx_49.ForeColor = Color.Red;
                else
                    tbx_49.ForeColor = Color.Blue;

                if (tbx_50_number != 0)
                    tbx_50.ForeColor = Color.Red;
                else
                    tbx_50.ForeColor = Color.Blue;

                if (tbx_51_number != 0)
                    tbx_51.ForeColor = Color.Red;
                else
                    tbx_51.ForeColor = Color.Blue;

                if (tbx_52_number != 0)
                    tbx_52.ForeColor = Color.Red;
                else
                    tbx_52.ForeColor = Color.Blue;

                if (tbx_53_number != 0)
                    tbx_53.ForeColor = Color.Red;
                else
                    tbx_53.ForeColor = Color.Blue;

                if (tbx_54_number != 0)
                    tbx_54.ForeColor = Color.Red;
                else
                    tbx_54.ForeColor = Color.Blue;

                if (tbx_55_number != 0)
                    tbx_55.ForeColor = Color.Red;
                else
                    tbx_55.ForeColor = Color.Blue;

                if (tbx_56_number != 0)
                    tbx_56.ForeColor = Color.Red;
                else
                    tbx_56.ForeColor = Color.Blue;

                if (tbx_57_number != 0)
                    tbx_57.ForeColor = Color.Red;
                else
                    tbx_57.ForeColor = Color.Blue;

                if (tbx_58_number != 0)
                    tbx_58.ForeColor = Color.Red;
                else
                    tbx_58.ForeColor = Color.Blue;

                if (tbx_59_number != 0)
                    tbx_59.ForeColor = Color.Red;
                else
                    tbx_59.ForeColor = Color.Blue;

                if (tbx_60_number != 0)
                    tbx_60.ForeColor = Color.Red;
                else
                    tbx_60.ForeColor = Color.Blue;

                if (tbx_61_number != 0)
                    tbx_61.ForeColor = Color.Red;
                else
                    tbx_61.ForeColor = Color.Blue;

                if (tbx_62_number != 0)
                    tbx_62.ForeColor = Color.Red;
                else
                    tbx_62.ForeColor = Color.Blue;

                if (tbx_63_number != 0)
                    tbx_63.ForeColor = Color.Red;
                else
                    tbx_63.ForeColor = Color.Blue;

                if (tbx_64_number != 0)
                    tbx_64.ForeColor = Color.Red;
                else
                    tbx_64.ForeColor = Color.Blue;

                if (tbx_65_number != 0)
                    tbx_65.ForeColor = Color.Red;
                else
                    tbx_65.ForeColor = Color.Blue;

                if (tbx_66_number != 0)
                    tbx_66.ForeColor = Color.Red;
                else
                    tbx_66.ForeColor = Color.Blue;

                if (tbx_67_number != 0)
                    tbx_67.ForeColor = Color.Red;
                else
                    tbx_67.ForeColor = Color.Blue;

                if (tbx_68_number != 0)
                    tbx_68.ForeColor = Color.Red;
                else
                    tbx_68.ForeColor = Color.Blue;

                if (tbx_69_number != 0)
                    tbx_69.ForeColor = Color.Red;
                else
                    tbx_69.ForeColor = Color.Blue;

                if (tbx_70_number != 0)
                    tbx_70.ForeColor = Color.Red;
                else
                    tbx_70.ForeColor = Color.Blue;

                if (tbx_71_number != 0)
                    tbx_71.ForeColor = Color.Red;
                else
                    tbx_71.ForeColor = Color.Blue;

                if (tbx_72_number != 0)
                    tbx_72.ForeColor = Color.Red;
                else
                    tbx_72.ForeColor = Color.Blue;

                if (tbx_73_number != 0)
                    tbx_73.ForeColor = Color.Red;
                else
                    tbx_73.ForeColor = Color.Blue;

                if (tbx_74_number != 0)
                    tbx_74.ForeColor = Color.Red;
                else
                    tbx_74.ForeColor = Color.Blue;

                if (tbx_75_number != 0)
                    tbx_75.ForeColor = Color.Red;
                else
                    tbx_75.ForeColor = Color.Blue;

                if (tbx_76_number != 0)
                    tbx_76.ForeColor = Color.Red;
                else
                    tbx_76.ForeColor = Color.Blue;

                if (tbx_77_number != 0)
                    tbx_77.ForeColor = Color.Red;
                else
                    tbx_77.ForeColor = Color.Blue;

                if (tbx_78_number != 0)
                    tbx_78.ForeColor = Color.Red;
                else
                    tbx_78.ForeColor = Color.Blue;

                if (tbx_79_number != 0)
                    tbx_79.ForeColor = Color.Red;
                else
                    tbx_79.ForeColor = Color.Blue;

                if (tbx_80_number != 0)
                    tbx_80.ForeColor = Color.Red;
                else
                    tbx_80.ForeColor = Color.Blue;

                if (tbx_81_number != 0)
                    tbx_81.ForeColor = Color.Red;
                else
                    tbx_81.ForeColor = Color.Blue;

            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            try
            {
                pbx_loading.Visible = true;
                btn_solve.Enabled = true;
                lbl_numOfResults.Text = "";
                lbl_currentPage.Text = "";

                tbx_1.ReadOnly = false;
                tbx_2.ReadOnly = false;
                tbx_3.ReadOnly = false;
                tbx_4.ReadOnly = false;
                tbx_5.ReadOnly = false;
                tbx_6.ReadOnly = false;
                tbx_7.ReadOnly = false;
                tbx_8.ReadOnly = false;
                tbx_9.ReadOnly = false;
                tbx_10.ReadOnly = false;
                tbx_11.ReadOnly = false;
                tbx_12.ReadOnly = false;
                tbx_13.ReadOnly = false;
                tbx_14.ReadOnly = false;
                tbx_15.ReadOnly = false;
                tbx_16.ReadOnly = false;
                tbx_17.ReadOnly = false;
                tbx_18.ReadOnly = false;
                tbx_19.ReadOnly = false;
                tbx_20.ReadOnly = false;
                tbx_21.ReadOnly = false;
                tbx_22.ReadOnly = false;
                tbx_23.ReadOnly = false;
                tbx_24.ReadOnly = false;
                tbx_25.ReadOnly = false;
                tbx_26.ReadOnly = false;
                tbx_27.ReadOnly = false;
                tbx_28.ReadOnly = false;
                tbx_29.ReadOnly = false;
                tbx_30.ReadOnly = false;
                tbx_31.ReadOnly = false;
                tbx_32.ReadOnly = false;
                tbx_33.ReadOnly = false;
                tbx_34.ReadOnly = false;
                tbx_35.ReadOnly = false;
                tbx_36.ReadOnly = false;
                tbx_37.ReadOnly = false;
                tbx_38.ReadOnly = false;
                tbx_39.ReadOnly = false;
                tbx_40.ReadOnly = false;
                tbx_41.ReadOnly = false;
                tbx_42.ReadOnly = false;
                tbx_43.ReadOnly = false;
                tbx_44.ReadOnly = false;
                tbx_45.ReadOnly = false;
                tbx_46.ReadOnly = false;
                tbx_47.ReadOnly = false;
                tbx_48.ReadOnly = false;
                tbx_49.ReadOnly = false;
                tbx_50.ReadOnly = false;
                tbx_51.ReadOnly = false;
                tbx_52.ReadOnly = false;
                tbx_53.ReadOnly = false;
                tbx_54.ReadOnly = false;
                tbx_55.ReadOnly = false;
                tbx_56.ReadOnly = false;
                tbx_57.ReadOnly = false;
                tbx_58.ReadOnly = false;
                tbx_59.ReadOnly = false;
                tbx_60.ReadOnly = false;
                tbx_61.ReadOnly = false;
                tbx_62.ReadOnly = false;
                tbx_63.ReadOnly = false;
                tbx_64.ReadOnly = false;
                tbx_65.ReadOnly = false;
                tbx_66.ReadOnly = false;
                tbx_67.ReadOnly = false;
                tbx_68.ReadOnly = false;
                tbx_69.ReadOnly = false;
                tbx_70.ReadOnly = false;
                tbx_71.ReadOnly = false;
                tbx_72.ReadOnly = false;
                tbx_73.ReadOnly = false;
                tbx_74.ReadOnly = false;
                tbx_75.ReadOnly = false;
                tbx_76.ReadOnly = false;
                tbx_77.ReadOnly = false;
                tbx_78.ReadOnly = false;
                tbx_79.ReadOnly = false;
                tbx_80.ReadOnly = false;
                tbx_81.ReadOnly = false;

                tbx_1.Text = "";
                tbx_2.Text = "";
                tbx_3.Text = "";
                tbx_4.Text = "";
                tbx_5.Text = "";
                tbx_6.Text = "";
                tbx_7.Text = "";
                tbx_8.Text = "";
                tbx_9.Text = "";
                tbx_10.Text = "";
                tbx_11.Text = "";
                tbx_12.Text = "";
                tbx_13.Text = "";
                tbx_14.Text = "";
                tbx_15.Text = "";
                tbx_16.Text = "";
                tbx_17.Text = "";
                tbx_18.Text = "";
                tbx_19.Text = "";
                tbx_20.Text = "";
                tbx_21.Text = "";
                tbx_22.Text = "";
                tbx_23.Text = "";
                tbx_24.Text = "";
                tbx_25.Text = "";
                tbx_26.Text = "";
                tbx_27.Text = "";
                tbx_28.Text = "";
                tbx_29.Text = "";
                tbx_30.Text = "";
                tbx_31.Text = "";
                tbx_32.Text = "";
                tbx_33.Text = "";
                tbx_34.Text = "";
                tbx_35.Text = "";
                tbx_36.Text = "";
                tbx_37.Text = "";
                tbx_38.Text = "";
                tbx_39.Text = "";
                tbx_40.Text = "";
                tbx_41.Text = "";
                tbx_42.Text = "";
                tbx_43.Text = "";
                tbx_44.Text = "";
                tbx_45.Text = "";
                tbx_46.Text = "";
                tbx_47.Text = "";
                tbx_48.Text = "";
                tbx_49.Text = "";
                tbx_50.Text = "";
                tbx_51.Text = "";
                tbx_52.Text = "";
                tbx_53.Text = "";
                tbx_54.Text = "";
                tbx_55.Text = "";
                tbx_56.Text = "";
                tbx_57.Text = "";
                tbx_58.Text = "";
                tbx_59.Text = "";
                tbx_60.Text = "";
                tbx_61.Text = "";
                tbx_62.Text = "";
                tbx_63.Text = "";
                tbx_64.Text = "";
                tbx_65.Text = "";
                tbx_66.Text = "";
                tbx_67.Text = "";
                tbx_68.Text = "";
                tbx_69.Text = "";
                tbx_70.Text = "";
                tbx_71.Text = "";
                tbx_72.Text = "";
                tbx_73.Text = "";
                tbx_74.Text = "";
                tbx_75.Text = "";
                tbx_76.Text = "";
                tbx_77.Text = "";
                tbx_78.Text = "";
                tbx_79.Text = "";
                tbx_80.Text = "";
                tbx_81.Text = "";

                tbx_1.ForeColor = Color.Black;
                tbx_2.ForeColor = Color.Black;
                tbx_3.ForeColor = Color.Black;
                tbx_4.ForeColor = Color.Black;
                tbx_5.ForeColor = Color.Black;
                tbx_6.ForeColor = Color.Black;
                tbx_7.ForeColor = Color.Black;
                tbx_8.ForeColor = Color.Black;
                tbx_9.ForeColor = Color.Black;
                tbx_10.ForeColor = Color.Black;
                tbx_11.ForeColor = Color.Black;
                tbx_12.ForeColor = Color.Black;
                tbx_13.ForeColor = Color.Black;
                tbx_14.ForeColor = Color.Black;
                tbx_15.ForeColor = Color.Black;
                tbx_16.ForeColor = Color.Black;
                tbx_17.ForeColor = Color.Black;
                tbx_18.ForeColor = Color.Black;
                tbx_19.ForeColor = Color.Black;
                tbx_20.ForeColor = Color.Black;
                tbx_21.ForeColor = Color.Black;
                tbx_22.ForeColor = Color.Black;
                tbx_23.ForeColor = Color.Black;
                tbx_24.ForeColor = Color.Black;
                tbx_25.ForeColor = Color.Black;
                tbx_26.ForeColor = Color.Black;
                tbx_27.ForeColor = Color.Black;
                tbx_28.ForeColor = Color.Black;
                tbx_29.ForeColor = Color.Black;
                tbx_30.ForeColor = Color.Black;
                tbx_31.ForeColor = Color.Black;
                tbx_32.ForeColor = Color.Black;
                tbx_33.ForeColor = Color.Black;
                tbx_34.ForeColor = Color.Black;
                tbx_35.ForeColor = Color.Black;
                tbx_36.ForeColor = Color.Black;
                tbx_37.ForeColor = Color.Black;
                tbx_38.ForeColor = Color.Black;
                tbx_39.ForeColor = Color.Black;
                tbx_40.ForeColor = Color.Black;
                tbx_41.ForeColor = Color.Black;
                tbx_42.ForeColor = Color.Black;
                tbx_43.ForeColor = Color.Black;
                tbx_44.ForeColor = Color.Black;
                tbx_45.ForeColor = Color.Black;
                tbx_46.ForeColor = Color.Black;
                tbx_47.ForeColor = Color.Black;
                tbx_48.ForeColor = Color.Black;
                tbx_49.ForeColor = Color.Black;
                tbx_50.ForeColor = Color.Black;
                tbx_51.ForeColor = Color.Black;
                tbx_52.ForeColor = Color.Black;
                tbx_53.ForeColor = Color.Black;
                tbx_54.ForeColor = Color.Black;
                tbx_55.ForeColor = Color.Black;
                tbx_56.ForeColor = Color.Black;
                tbx_57.ForeColor = Color.Black;
                tbx_58.ForeColor = Color.Black;
                tbx_59.ForeColor = Color.Black;
                tbx_60.ForeColor = Color.Black;
                tbx_61.ForeColor = Color.Black;
                tbx_62.ForeColor = Color.Black;
                tbx_63.ForeColor = Color.Black;
                tbx_64.ForeColor = Color.Black;
                tbx_65.ForeColor = Color.Black;
                tbx_66.ForeColor = Color.Black;
                tbx_67.ForeColor = Color.Black;
                tbx_68.ForeColor = Color.Black;
                tbx_69.ForeColor = Color.Black;
                tbx_70.ForeColor = Color.Black;
                tbx_71.ForeColor = Color.Black;
                tbx_72.ForeColor = Color.Black;
                tbx_73.ForeColor = Color.Black;
                tbx_74.ForeColor = Color.Black;
                tbx_75.ForeColor = Color.Black;
                tbx_76.ForeColor = Color.Black;
                tbx_77.ForeColor = Color.Black;
                tbx_78.ForeColor = Color.Black;
                tbx_79.ForeColor = Color.Black;
                tbx_80.ForeColor = Color.Black;
                tbx_81.ForeColor = Color.Black;

                resetCtor();
                resetLoad();

                pbx_loading.Visible = false;
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        #region TextBox TextChanged methods for number of inputs

        private void tbx_1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_1.Text != "" && tbx_1.Text != "0")
                {
                    tbx_1_used = true;
                    numOfInputs++;
                }
                else if (tbx_1.Text == "" || tbx_1.Text == "0" && tbx_1_used == true)
                {
                    tbx_1_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_2.Text != "" && tbx_2.Text != "0")
                {
                    tbx_2_used = true;
                    numOfInputs++;
                }
                else if (tbx_2.Text == "" || tbx_2.Text == "0" && tbx_2_used == true)
                {
                    tbx_2_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_3.Text != "" && tbx_3.Text != "0")
                {
                    tbx_3_used = true;
                    numOfInputs++;
                }
                else if (tbx_3.Text == "" || tbx_3.Text == "0" && tbx_3_used == true)
                {
                    tbx_3_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_4.Text != "" && tbx_4.Text != "0")
                {
                    tbx_4_used = true;
                    numOfInputs++;
                }
                else if (tbx_4.Text == "" || tbx_4.Text == "0" && tbx_4_used == true)
                {
                    tbx_4_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_5.Text != "" && tbx_5.Text != "0")
                {
                    tbx_5_used = true;
                    numOfInputs++;
                }
                else if (tbx_5.Text == "" || tbx_5.Text == "0" && tbx_5_used == true)
                {
                    tbx_5_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_6.Text != "" && tbx_6.Text != "0")
                {
                    tbx_6_used = true;
                    numOfInputs++;
                }
                else if (tbx_6.Text == "" || tbx_6.Text == "0" && tbx_6_used == true)
                {
                    tbx_6_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_7.Text != "" && tbx_7.Text != "0")
                {
                    tbx_7_used = true;
                    numOfInputs++;
                }
                else if (tbx_7.Text == "" || tbx_7.Text == "0" && tbx_7_used == true)
                {
                    tbx_7_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_8.Text != "" && tbx_8.Text != "0")
                {
                    tbx_8_used = true;
                    numOfInputs++;
                }
                else if (tbx_8.Text == "" || tbx_8.Text == "0" && tbx_8_used == true)
                {
                    tbx_8_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_9.Text != "" && tbx_9.Text != "0")
                {
                    tbx_9_used = true;
                    numOfInputs++;
                }
                else if (tbx_9.Text == "" || tbx_9.Text == "0" && tbx_9_used == true)
                {
                    tbx_9_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_10.Text != "" && tbx_10.Text != "0")
                {
                    tbx_10_used = true;
                    numOfInputs++;
                }
                else if (tbx_10.Text == "" || tbx_10.Text == "0" && tbx_10_used == true)
                {
                    tbx_10_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_11_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_11.Text != "" && tbx_11.Text != "0")
                {
                    tbx_11_used = true;
                    numOfInputs++;
                }
                else if (tbx_11.Text == "" || tbx_11.Text == "0" && tbx_11_used == true)
                {
                    tbx_11_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_12_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_12.Text != "" && tbx_12.Text != "0")
                {
                    tbx_12_used = true;
                    numOfInputs++;
                }
                else if (tbx_12.Text == "" || tbx_12.Text == "0" && tbx_12_used == true)
                {
                    tbx_12_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_13_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_13.Text != "" && tbx_13.Text != "0")
                {
                    tbx_13_used = true;
                    numOfInputs++;
                }
                else if (tbx_13.Text == "" || tbx_13.Text == "0" && tbx_13_used == true)
                {
                    tbx_13_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_14_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_14.Text != "" && tbx_14.Text != "0")
                {
                    tbx_14_used = true;
                    numOfInputs++;
                }
                else if (tbx_14.Text == "" || tbx_14.Text == "0" && tbx_14_used == true)
                {
                    tbx_14_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_15_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_15.Text != "" && tbx_15.Text != "0")
                {
                    tbx_15_used = true;
                    numOfInputs++;
                }
                else if (tbx_15.Text == "" || tbx_15.Text == "0" && tbx_15_used == true)
                {
                    tbx_15_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_16_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_16.Text != "" && tbx_16.Text != "0")
                {
                    tbx_16_used = true;
                    numOfInputs++;
                }
                else if (tbx_16.Text == "" || tbx_16.Text == "0" && tbx_16_used == true)
                {
                    tbx_16_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_17_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_17.Text != "" && tbx_17.Text != "0")
                {
                    tbx_17_used = true;
                    numOfInputs++;
                }
                else if (tbx_17.Text == "" || tbx_17.Text == "0" && tbx_17_used == true)
                {
                    tbx_17_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_18_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_18.Text != "" && tbx_18.Text != "0")
                {
                    tbx_18_used = true;
                    numOfInputs++;
                }
                else if (tbx_18.Text == "" || tbx_18.Text == "0" && tbx_18_used == true)
                {
                    tbx_18_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_19_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_19.Text != "" && tbx_19.Text != "0")
                {
                    tbx_19_used = true;
                    numOfInputs++;
                }
                else if (tbx_19.Text == "" || tbx_19.Text == "0" && tbx_19_used == true)
                {
                    tbx_19_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_20_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_20.Text != "" && tbx_20.Text != "0")
                {
                    tbx_20_used = true;
                    numOfInputs++;
                }
                else if (tbx_20.Text == "" || tbx_20.Text == "0" && tbx_20_used == true)
                {
                    tbx_20_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_21_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_21.Text != "" && tbx_21.Text != "0")
                {
                    tbx_21_used = true;
                    numOfInputs++;
                }
                else if (tbx_21.Text == "" || tbx_21.Text == "0" && tbx_21_used == true)
                {
                    tbx_21_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_22_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_22.Text != "" && tbx_22.Text != "0")
                {
                    tbx_22_used = true;
                    numOfInputs++;
                }
                else if (tbx_22.Text == "" || tbx_22.Text == "0" && tbx_22_used == true)
                {
                    tbx_22_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_23_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_23.Text != "" && tbx_23.Text != "0")
                {
                    tbx_23_used = true;
                    numOfInputs++;
                }
                else if (tbx_23.Text == "" || tbx_23.Text == "0" && tbx_23_used == true)
                {
                    tbx_23_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_24_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_24.Text != "" && tbx_24.Text != "0")
                {
                    tbx_24_used = true;
                    numOfInputs++;
                }
                else if (tbx_24.Text == "" || tbx_24.Text == "0" && tbx_24_used == true)
                {
                    tbx_24_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_25_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_25.Text != "" && tbx_25.Text != "0")
                {
                    tbx_25_used = true;
                    numOfInputs++;
                }
                else if (tbx_25.Text == "" || tbx_25.Text == "0" && tbx_25_used == true)
                {
                    tbx_25_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_26_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_26.Text != "" && tbx_26.Text != "0")
                {
                    tbx_26_used = true;
                    numOfInputs++;
                }
                else if (tbx_26.Text == "" || tbx_26.Text == "0" && tbx_26_used == true)
                {
                    tbx_26_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_27_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_27.Text != "" && tbx_27.Text != "0")
                {
                    tbx_27_used = true;
                    numOfInputs++;
                }
                else if (tbx_27.Text == "" || tbx_27.Text == "0" && tbx_27_used == true)
                {
                    tbx_27_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_28_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_28.Text != "" && tbx_28.Text != "0")
                {
                    tbx_28_used = true;
                    numOfInputs++;
                }
                else if (tbx_28.Text == "" || tbx_28.Text == "0" && tbx_28_used == true)
                {
                    tbx_28_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_29_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_29.Text != "" && tbx_29.Text != "0")
                {
                    tbx_29_used = true;
                    numOfInputs++;
                }
                else if (tbx_29.Text == "" || tbx_29.Text == "0" && tbx_29_used == true)
                {
                    tbx_29_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_30_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_30.Text != "" && tbx_30.Text != "0")
                {
                    tbx_30_used = true;
                    numOfInputs++;
                }
                else if (tbx_30.Text == "" || tbx_30.Text == "0" && tbx_30_used == true)
                {
                    tbx_30_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_31_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_31.Text != "" && tbx_31.Text != "0")
                {
                    tbx_31_used = true;
                    numOfInputs++;
                }
                else if (tbx_31.Text == "" || tbx_31.Text == "0" && tbx_31_used == true)
                {
                    tbx_31_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_32_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_32.Text != "" && tbx_32.Text != "0")
                {
                    tbx_32_used = true;
                    numOfInputs++;
                }
                else if (tbx_32.Text == "" || tbx_32.Text == "0" && tbx_32_used == true)
                {
                    tbx_32_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_33_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_33.Text != "" && tbx_33.Text != "0")
                {
                    tbx_33_used = true;
                    numOfInputs++;
                }
                else if (tbx_33.Text == "" || tbx_33.Text == "0" && tbx_33_used == true)
                {
                    tbx_33_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_34_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_34.Text != "" && tbx_34.Text != "0")
                {
                    tbx_34_used = true;
                    numOfInputs++;
                }
                else if (tbx_34.Text == "" || tbx_34.Text == "0" && tbx_34_used == true)
                {
                    tbx_34_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_35_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_35.Text != "" && tbx_35.Text != "0")
                {
                    tbx_35_used = true;
                    numOfInputs++;
                }
                else if (tbx_35.Text == "" || tbx_35.Text == "0" && tbx_35_used == true)
                {
                    tbx_35_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_36_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_36.Text != "" && tbx_36.Text != "0")
                {
                    tbx_36_used = true;
                    numOfInputs++;
                }
                else if (tbx_36.Text == "" || tbx_36.Text == "0" && tbx_36_used == true)
                {
                    tbx_36_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_37_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_37.Text != "" && tbx_37.Text != "0")
                {
                    tbx_37_used = true;
                    numOfInputs++;
                }
                else if (tbx_37.Text == "" || tbx_37.Text == "0" && tbx_37_used == true)
                {
                    tbx_37_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_38_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_38.Text != "" && tbx_38.Text != "0")
                {
                    tbx_38_used = true;
                    numOfInputs++;
                }
                else if (tbx_38.Text == "" || tbx_38.Text == "0" && tbx_38_used == true)
                {
                    tbx_38_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_39_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_39.Text != "" && tbx_39.Text != "0")
                {
                    tbx_39_used = true;
                    numOfInputs++;
                }
                else if (tbx_39.Text == "" || tbx_39.Text == "0" && tbx_39_used == true)
                {
                    tbx_39_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_40_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_40.Text != "" && tbx_40.Text != "0")
                {
                    tbx_40_used = true;
                    numOfInputs++;
                }
                else if (tbx_40.Text == "" || tbx_40.Text == "0" && tbx_40_used == true)
                {
                    tbx_40_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_41_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_41.Text != "" && tbx_41.Text != "0")
                {
                    tbx_41_used = true;
                    numOfInputs++;
                }
                else if (tbx_41.Text == "" || tbx_41.Text == "0" && tbx_41_used == true)
                {
                    tbx_41_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_42_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_42.Text != "" && tbx_42.Text != "0")
                {
                    tbx_42_used = true;
                    numOfInputs++;
                }
                else if (tbx_42.Text == "" || tbx_42.Text == "0" && tbx_42_used == true)
                {
                    tbx_42_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_43_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_43.Text != "" && tbx_43.Text != "0")
                {
                    tbx_43_used = true;
                    numOfInputs++;
                }
                else if (tbx_43.Text == "" || tbx_43.Text == "0" && tbx_43_used == true)
                {
                    tbx_43_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_44_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_44.Text != "" && tbx_44.Text != "0")
                {
                    tbx_44_used = true;
                    numOfInputs++;
                }
                else if (tbx_44.Text == "" || tbx_44.Text == "0" && tbx_44_used == true)
                {
                    tbx_44_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_45_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_45.Text != "" && tbx_45.Text != "0")
                {
                    tbx_45_used = true;
                    numOfInputs++;
                }
                else if (tbx_45.Text == "" || tbx_45.Text == "0" && tbx_45_used == true)
                {
                    tbx_45_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_46_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_46.Text != "" && tbx_46.Text != "0")
                {
                    tbx_46_used = true;
                    numOfInputs++;
                }
                else if (tbx_46.Text == "" || tbx_46.Text == "0" && tbx_46_used == true)
                {
                    tbx_46_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_47_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_47.Text != "" && tbx_47.Text != "0")
                {
                    tbx_47_used = true;
                    numOfInputs++;
                }
                else if (tbx_47.Text == "" || tbx_47.Text == "0" && tbx_47_used == true)
                {
                    tbx_47_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_48_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_48.Text != "" && tbx_48.Text != "0")
                {
                    tbx_48_used = true;
                    numOfInputs++;
                }
                else if (tbx_48.Text == "" || tbx_48.Text == "0" && tbx_48_used == true)
                {
                    tbx_48_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_49_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_49.Text != "" && tbx_49.Text != "0")
                {
                    tbx_49_used = true;
                    numOfInputs++;
                }
                else if (tbx_49.Text == "" || tbx_49.Text == "0" && tbx_49_used == true)
                {
                    tbx_49_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_50_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_50.Text != "" && tbx_50.Text != "0")
                {
                    tbx_50_used = true;
                    numOfInputs++;
                }
                else if (tbx_50.Text == "" || tbx_50.Text == "0" && tbx_50_used == true)
                {
                    tbx_50_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_51_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_51.Text != "" && tbx_51.Text != "0")
                {
                    tbx_51_used = true;
                    numOfInputs++;
                }
                else if (tbx_51.Text == "" || tbx_51.Text == "0" && tbx_51_used == true)
                {
                    tbx_51_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_52_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_52.Text != "" && tbx_52.Text != "0")
                {
                    tbx_52_used = true;
                    numOfInputs++;
                }
                else if (tbx_52.Text == "" || tbx_52.Text == "0" && tbx_52_used == true)
                {
                    tbx_52_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_53_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_53.Text != "" && tbx_53.Text != "0")
                {
                    tbx_53_used = true;
                    numOfInputs++;
                }
                else if (tbx_53.Text == "" || tbx_53.Text == "0" && tbx_53_used == true)
                {
                    tbx_53_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_54_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_54.Text != "" && tbx_54.Text != "0")
                {
                    tbx_54_used = true;
                    numOfInputs++;
                }
                else if (tbx_54.Text == "" || tbx_54.Text == "0" && tbx_54_used == true)
                {
                    tbx_54_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_55_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_55.Text != "" && tbx_55.Text != "0")
                {
                    tbx_55_used = true;
                    numOfInputs++;
                }
                else if (tbx_55.Text == "" || tbx_55.Text == "0" && tbx_55_used == true)
                {
                    tbx_55_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_56_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_56.Text != "" && tbx_56.Text != "0")
                {
                    tbx_56_used = true;
                    numOfInputs++;
                }
                else if (tbx_56.Text == "" || tbx_56.Text == "0" && tbx_56_used == true)
                {
                    tbx_56_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_57_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_57.Text != "" && tbx_57.Text != "0")
                {
                    tbx_57_used = true;
                    numOfInputs++;
                }
                else if (tbx_57.Text == "" || tbx_57.Text == "0" && tbx_57_used == true)
                {
                    tbx_57_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_58_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_58.Text != "" && tbx_58.Text != "0")
                {
                    tbx_58_used = true;
                    numOfInputs++;
                }
                else if (tbx_58.Text == "" || tbx_58.Text == "0" && tbx_58_used == true)
                {
                    tbx_58_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_59_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_59.Text != "" && tbx_59.Text != "0")
                {
                    tbx_59_used = true;
                    numOfInputs++;
                }
                else if (tbx_59.Text == "" || tbx_59.Text == "0" && tbx_59_used == true)
                {
                    tbx_59_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_60_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_60.Text != "" && tbx_60.Text != "0")
                {
                    tbx_60_used = true;
                    numOfInputs++;
                }
                else if (tbx_60.Text == "" || tbx_60.Text == "0" && tbx_60_used == true)
                {
                    tbx_60_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_61_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_61.Text != "" && tbx_61.Text != "0")
                {
                    tbx_61_used = true;
                    numOfInputs++;
                }
                else if (tbx_61.Text == "" || tbx_61.Text == "0" && tbx_61_used == true)
                {
                    tbx_61_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_62_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_62.Text != "" && tbx_62.Text != "0")
                {
                    tbx_62_used = true;
                    numOfInputs++;
                }
                else if (tbx_62.Text == "" || tbx_62.Text == "0" && tbx_62_used == true)
                {
                    tbx_62_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_63_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_63.Text != "" && tbx_63.Text != "0")
                {
                    tbx_63_used = true;
                    numOfInputs++;
                }
                else if (tbx_63.Text == "" || tbx_63.Text == "0" && tbx_63_used == true)
                {
                    tbx_63_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_64_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_64.Text != "" && tbx_64.Text != "0")
                {
                    tbx_64_used = true;
                    numOfInputs++;
                }
                else if (tbx_64.Text == "" || tbx_64.Text == "0" && tbx_64_used == true)
                {
                    tbx_64_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_65_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_65.Text != "" && tbx_65.Text != "0")
                {
                    tbx_65_used = true;
                    numOfInputs++;
                }
                else if (tbx_65.Text == "" || tbx_65.Text == "0" && tbx_65_used == true)
                {
                    tbx_65_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_66_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_66.Text != "" && tbx_66.Text != "0")
                {
                    tbx_66_used = true;
                    numOfInputs++;
                }
                else if (tbx_66.Text == "" || tbx_66.Text == "0" && tbx_66_used == true)
                {
                    tbx_66_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_67_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_67.Text != "" && tbx_67.Text != "0")
                {
                    tbx_67_used = true;
                    numOfInputs++;
                }
                else if (tbx_67.Text == "" || tbx_67.Text == "0" && tbx_67_used == true)
                {
                    tbx_67_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_68_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_68.Text != "" && tbx_68.Text != "0")
                {
                    tbx_68_used = true;
                    numOfInputs++;
                }
                else if (tbx_68.Text == "" || tbx_68.Text == "0" && tbx_68_used == true)
                {
                    tbx_68_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_69_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_69.Text != "" && tbx_69.Text != "0")
                {
                    tbx_69_used = true;
                    numOfInputs++;
                }
                else if (tbx_69.Text == "" || tbx_69.Text == "0" && tbx_69_used == true)
                {
                    tbx_69_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_70_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_70.Text != "" && tbx_70.Text != "0")
                {
                    tbx_70_used = true;
                    numOfInputs++;
                }
                else if (tbx_70.Text == "" || tbx_70.Text == "0" && tbx_70_used == true)
                {
                    tbx_70_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_71_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_71.Text != "" && tbx_71.Text != "0")
                {
                    tbx_71_used = true;
                    numOfInputs++;
                }
                else if (tbx_71.Text == "" || tbx_71.Text == "0" && tbx_71_used == true)
                {
                    tbx_71_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_72_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_72.Text != "" && tbx_72.Text != "0")
                {
                    tbx_72_used = true;
                    numOfInputs++;
                }
                else if (tbx_72.Text == "" || tbx_72.Text == "0" && tbx_72_used == true)
                {
                    tbx_72_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_73_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_73.Text != "" && tbx_73.Text != "0")
                {
                    tbx_73_used = true;
                    numOfInputs++;
                }
                else if (tbx_73.Text == "" || tbx_73.Text == "0" && tbx_73_used == true)
                {
                    tbx_73_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_74_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_74.Text != "" && tbx_74.Text != "0")
                {
                    tbx_74_used = true;
                    numOfInputs++;
                }
                else if (tbx_74.Text == "" || tbx_74.Text == "0" && tbx_74_used == true)
                {
                    tbx_74_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_75_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_75.Text != "" && tbx_75.Text != "0")
                {
                    tbx_75_used = true;
                    numOfInputs++;
                }
                else if (tbx_75.Text == "" || tbx_75.Text == "0" && tbx_75_used == true)
                {
                    tbx_75_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_76_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_76.Text != "" && tbx_76.Text != "0")
                {
                    tbx_76_used = true;
                    numOfInputs++;
                }
                else if (tbx_76.Text == "" || tbx_76.Text == "0" && tbx_76_used == true)
                {
                    tbx_76_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_77_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_77.Text != "" && tbx_77.Text != "0")
                {
                    tbx_77_used = true;
                    numOfInputs++;
                }
                else if (tbx_77.Text == "" || tbx_77.Text == "0" && tbx_77_used == true)
                {
                    tbx_77_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_78_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_78.Text != "" && tbx_78.Text != "0")
                {
                    tbx_78_used = true;
                    numOfInputs++;
                }
                else if (tbx_78.Text == "" || tbx_78.Text == "0" && tbx_78_used == true)
                {
                    tbx_78_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_79_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_79.Text != "" && tbx_79.Text != "0")
                {
                    tbx_79_used = true;
                    numOfInputs++;
                }
                else if (tbx_79.Text == "" || tbx_79.Text == "0" && tbx_79_used == true)
                {
                    tbx_79_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_80_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_80.Text != "" && tbx_80.Text != "0")
                {
                    tbx_80_used = true;
                    numOfInputs++;
                }
                else if (tbx_80.Text == "" || tbx_80.Text == "0" && tbx_80_used == true)
                {
                    tbx_80_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_81_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_81.Text != "" && tbx_81.Text != "0")
                {
                    tbx_81_used = true;
                    numOfInputs++;
                }
                else if (tbx_81.Text == "" || tbx_81.Text == "0" && tbx_81_used == true)
                {
                    tbx_81_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        #endregion

        private sudokuGrid serializeGrid()
        {
            try
            {
                sudokuGrid grid = new sudokuGrid();
                grid.square_1 = tbx_1_number;
                grid.square_2 = tbx_2_number;
                grid.square_3 = tbx_3_number;
                grid.square_4 = tbx_4_number;
                grid.square_5 = tbx_5_number;
                grid.square_6 = tbx_6_number;
                grid.square_7 = tbx_7_number;
                grid.square_8 = tbx_8_number;
                grid.square_9 = tbx_9_number;
                grid.square_10 = tbx_10_number;
                grid.square_11 = tbx_11_number;
                grid.square_12 = tbx_12_number;
                grid.square_13 = tbx_13_number;
                grid.square_14 = tbx_14_number;
                grid.square_15 = tbx_15_number;
                grid.square_16 = tbx_16_number;
                grid.square_17 = tbx_17_number;
                grid.square_18 = tbx_18_number;
                grid.square_19 = tbx_19_number;
                grid.square_20 = tbx_20_number;
                grid.square_21 = tbx_21_number;
                grid.square_22 = tbx_22_number;
                grid.square_23 = tbx_23_number;
                grid.square_24 = tbx_24_number;
                grid.square_25 = tbx_25_number;
                grid.square_26 = tbx_26_number;
                grid.square_27 = tbx_27_number;
                grid.square_28 = tbx_28_number;
                grid.square_29 = tbx_29_number;
                grid.square_30 = tbx_30_number;
                grid.square_31 = tbx_31_number;
                grid.square_32 = tbx_32_number;
                grid.square_33 = tbx_33_number;
                grid.square_34 = tbx_34_number;
                grid.square_35 = tbx_35_number;
                grid.square_36 = tbx_36_number;
                grid.square_37 = tbx_37_number;
                grid.square_38 = tbx_38_number;
                grid.square_39 = tbx_39_number;
                grid.square_40 = tbx_40_number;
                grid.square_41 = tbx_41_number;
                grid.square_42 = tbx_42_number;
                grid.square_43 = tbx_43_number;
                grid.square_44 = tbx_44_number;
                grid.square_45 = tbx_45_number;
                grid.square_46 = tbx_46_number;
                grid.square_47 = tbx_47_number;
                grid.square_48 = tbx_48_number;
                grid.square_49 = tbx_49_number;
                grid.square_50 = tbx_50_number;
                grid.square_51 = tbx_51_number;
                grid.square_52 = tbx_52_number;
                grid.square_53 = tbx_53_number;
                grid.square_54 = tbx_54_number;
                grid.square_55 = tbx_55_number;
                grid.square_56 = tbx_56_number;
                grid.square_57 = tbx_57_number;
                grid.square_58 = tbx_58_number;
                grid.square_59 = tbx_59_number;
                grid.square_60 = tbx_60_number;
                grid.square_61 = tbx_61_number;
                grid.square_62 = tbx_62_number;
                grid.square_63 = tbx_63_number;
                grid.square_64 = tbx_64_number;
                grid.square_65 = tbx_65_number;
                grid.square_66 = tbx_66_number;
                grid.square_67 = tbx_67_number;
                grid.square_68 = tbx_68_number;
                grid.square_69 = tbx_69_number;
                grid.square_70 = tbx_70_number;
                grid.square_71 = tbx_71_number;
                grid.square_72 = tbx_72_number;
                grid.square_73 = tbx_73_number;
                grid.square_74 = tbx_74_number;
                grid.square_75 = tbx_75_number;
                grid.square_76 = tbx_76_number;
                grid.square_77 = tbx_77_number;
                grid.square_78 = tbx_78_number;
                grid.square_79 = tbx_79_number;
                grid.square_80 = tbx_80_number;
                grid.square_81 = tbx_81_number;
                return grid;
            }
            catch (Exception ex)
            {
                errorHandler(ex);
                return null;
            }
        }

        private bool checkIfReal()
        {
            try
            {
                if (check_square() == true && check_vertical() == true && check_horizontal() == true)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                errorHandler(ex);
                return false;
            }
        }

        private bool check_square()
        {
            try
            {
                #region variables
                int square_1_1 = 0;
                int square_1_2 = 0;
                int square_1_3 = 0;
                int square_1_4 = 0;
                int square_1_5 = 0;
                int square_1_6 = 0;
                int square_1_7 = 0;
                int square_1_8 = 0;
                int square_1_9 = 0;
                int square_2_1 = 0;
                int square_2_2 = 0;
                int square_2_3 = 0;
                int square_2_4 = 0;
                int square_2_5 = 0;
                int square_2_6 = 0;
                int square_2_7 = 0;
                int square_2_8 = 0;
                int square_2_9 = 0;
                int square_3_1 = 0;
                int square_3_2 = 0;
                int square_3_3 = 0;
                int square_3_4 = 0;
                int square_3_5 = 0;
                int square_3_6 = 0;
                int square_3_7 = 0;
                int square_3_8 = 0;
                int square_3_9 = 0;
                int square_4_1 = 0;
                int square_4_2 = 0;
                int square_4_3 = 0;
                int square_4_4 = 0;
                int square_4_5 = 0;
                int square_4_6 = 0;
                int square_4_7 = 0;
                int square_4_8 = 0;
                int square_4_9 = 0;
                int square_5_1 = 0;
                int square_5_2 = 0;
                int square_5_3 = 0;
                int square_5_4 = 0;
                int square_5_5 = 0;
                int square_5_6 = 0;
                int square_5_7 = 0;
                int square_5_8 = 0;
                int square_5_9 = 0;
                int square_6_1 = 0;
                int square_6_2 = 0;
                int square_6_3 = 0;
                int square_6_4 = 0;
                int square_6_5 = 0;
                int square_6_6 = 0;
                int square_6_7 = 0;
                int square_6_8 = 0;
                int square_6_9 = 0;
                int square_7_1 = 0;
                int square_7_2 = 0;
                int square_7_3 = 0;
                int square_7_4 = 0;
                int square_7_5 = 0;
                int square_7_6 = 0;
                int square_7_7 = 0;
                int square_7_8 = 0;
                int square_7_9 = 0;
                int square_8_1 = 0;
                int square_8_2 = 0;
                int square_8_3 = 0;
                int square_8_4 = 0;
                int square_8_5 = 0;
                int square_8_6 = 0;
                int square_8_7 = 0;
                int square_8_8 = 0;
                int square_8_9 = 0;
                int square_9_1 = 0;
                int square_9_2 = 0;
                int square_9_3 = 0;
                int square_9_4 = 0;
                int square_9_5 = 0;
                int square_9_6 = 0;
                int square_9_7 = 0;
                int square_9_8 = 0;
                int square_9_9 = 0;
                #endregion

                List<int> square_1 = new List<int>();
                List<int> square_2 = new List<int>();
                List<int> square_3 = new List<int>();
                List<int> square_4 = new List<int>();
                List<int> square_5 = new List<int>();
                List<int> square_6 = new List<int>();
                List<int> square_7 = new List<int>();
                List<int> square_8 = new List<int>();
                List<int> square_9 = new List<int>();

                square_1.Add(tbx_1_number);
                square_1.Add(tbx_2_number);
                square_1.Add(tbx_3_number);
                square_1.Add(tbx_10_number);
                square_1.Add(tbx_11_number);
                square_1.Add(tbx_12_number);
                square_1.Add(tbx_19_number);
                square_1.Add(tbx_20_number);
                square_1.Add(tbx_21_number);

                square_2.Add(tbx_4_number);
                square_2.Add(tbx_5_number);
                square_2.Add(tbx_6_number);
                square_2.Add(tbx_13_number);
                square_2.Add(tbx_14_number);
                square_2.Add(tbx_15_number);
                square_2.Add(tbx_22_number);
                square_2.Add(tbx_23_number);
                square_2.Add(tbx_24_number);

                square_3.Add(tbx_7_number);
                square_3.Add(tbx_8_number);
                square_3.Add(tbx_9_number);
                square_3.Add(tbx_16_number);
                square_3.Add(tbx_17_number);
                square_3.Add(tbx_18_number);
                square_3.Add(tbx_25_number);
                square_3.Add(tbx_26_number);
                square_3.Add(tbx_27_number);

                square_4.Add(tbx_28_number);
                square_4.Add(tbx_29_number);
                square_4.Add(tbx_30_number);
                square_4.Add(tbx_37_number);
                square_4.Add(tbx_38_number);
                square_4.Add(tbx_39_number);
                square_4.Add(tbx_46_number);
                square_4.Add(tbx_47_number);
                square_4.Add(tbx_48_number);

                square_5.Add(tbx_31_number);
                square_5.Add(tbx_32_number);
                square_5.Add(tbx_33_number);
                square_5.Add(tbx_40_number);
                square_5.Add(tbx_41_number);
                square_5.Add(tbx_42_number);
                square_5.Add(tbx_49_number);
                square_5.Add(tbx_50_number);
                square_5.Add(tbx_51_number);

                square_6.Add(tbx_34_number);
                square_6.Add(tbx_35_number);
                square_6.Add(tbx_36_number);
                square_6.Add(tbx_43_number);
                square_6.Add(tbx_44_number);
                square_6.Add(tbx_45_number);
                square_6.Add(tbx_52_number);
                square_6.Add(tbx_53_number);
                square_6.Add(tbx_54_number);

                square_7.Add(tbx_55_number);
                square_7.Add(tbx_56_number);
                square_7.Add(tbx_57_number);
                square_7.Add(tbx_64_number);
                square_7.Add(tbx_65_number);
                square_7.Add(tbx_66_number);
                square_7.Add(tbx_73_number);
                square_7.Add(tbx_74_number);
                square_7.Add(tbx_75_number);

                square_8.Add(tbx_58_number);
                square_8.Add(tbx_59_number);
                square_8.Add(tbx_60_number);
                square_8.Add(tbx_67_number);
                square_8.Add(tbx_68_number);
                square_8.Add(tbx_69_number);
                square_8.Add(tbx_76_number);
                square_8.Add(tbx_77_number);
                square_8.Add(tbx_78_number);

                square_9.Add(tbx_61_number);
                square_9.Add(tbx_62_number);
                square_9.Add(tbx_63_number);
                square_9.Add(tbx_70_number);
                square_9.Add(tbx_71_number);
                square_9.Add(tbx_72_number);
                square_9.Add(tbx_79_number);
                square_9.Add(tbx_80_number);
                square_9.Add(tbx_81_number);

                if ((square_1.Where(s => s.Equals(1)).Count()) >= 2)
                    return false;
                if ((square_1.Where(s => s.Equals(2)).Count()) >= 2)
                    return false;
                if ((square_1.Where(s => s.Equals(3)).Count()) >= 2)
                    return false;
                if ((square_1.Where(s => s.Equals(4)).Count()) >= 2)
                    return false;
                if ((square_1.Where(s => s.Equals(5)).Count()) >= 2)
                    return false;
                if ((square_1.Where(s => s.Equals(6)).Count()) >= 2)
                    return false;
                if ((square_1.Where(s => s.Equals(7)).Count()) >= 2)
                    return false;
                if ((square_1.Where(s => s.Equals(8)).Count()) >= 2)
                    return false;
                if ((square_1.Where(s => s.Equals(9)).Count()) >= 2)
                    return false;

                if ((square_2.Where(s => s.Equals(1)).Count()) >= 2)
                    return false;
                if ((square_2.Where(s => s.Equals(2)).Count()) >= 2)
                    return false;
                if ((square_2.Where(s => s.Equals(3)).Count()) >= 2)
                    return false;
                if ((square_2.Where(s => s.Equals(4)).Count()) >= 2)
                    return false;
                if ((square_2.Where(s => s.Equals(5)).Count()) >= 2)
                    return false;
                if ((square_2.Where(s => s.Equals(6)).Count()) >= 2)
                    return false;
                if ((square_2.Where(s => s.Equals(7)).Count()) >= 2)
                    return false;
                if ((square_2.Where(s => s.Equals(8)).Count()) >= 2)
                    return false;
                if ((square_2.Where(s => s.Equals(9)).Count()) >= 2)
                    return false;

                if ((square_3.Where(s => s.Equals(1)).Count()) >= 2)
                    return false;
                if ((square_3.Where(s => s.Equals(2)).Count()) >= 2)
                    return false;
                if ((square_3.Where(s => s.Equals(3)).Count()) >= 2)
                    return false;
                if ((square_3.Where(s => s.Equals(4)).Count()) >= 2)
                    return false;
                if ((square_3.Where(s => s.Equals(5)).Count()) >= 2)
                    return false;
                if ((square_3.Where(s => s.Equals(6)).Count()) >= 2)
                    return false;
                if ((square_3.Where(s => s.Equals(7)).Count()) >= 2)
                    return false;
                if ((square_3.Where(s => s.Equals(8)).Count()) >= 2)
                    return false;
                if ((square_3.Where(s => s.Equals(9)).Count()) >= 2)
                    return false;

                if ((square_4.Where(s => s.Equals(1)).Count()) >= 2)
                    return false;
                if ((square_4.Where(s => s.Equals(2)).Count()) >= 2)
                    return false;
                if ((square_4.Where(s => s.Equals(3)).Count()) >= 2)
                    return false;
                if ((square_4.Where(s => s.Equals(4)).Count()) >= 2)
                    return false;
                if ((square_4.Where(s => s.Equals(5)).Count()) >= 2)
                    return false;
                if ((square_4.Where(s => s.Equals(6)).Count()) >= 2)
                    return false;
                if ((square_4.Where(s => s.Equals(7)).Count()) >= 2)
                    return false;
                if ((square_4.Where(s => s.Equals(8)).Count()) >= 2)
                    return false;
                if ((square_4.Where(s => s.Equals(9)).Count()) >= 2)
                    return false;

                if ((square_5.Where(s => s.Equals(1)).Count()) >= 2)
                    return false;
                if ((square_5.Where(s => s.Equals(2)).Count()) >= 2)
                    return false;
                if ((square_5.Where(s => s.Equals(3)).Count()) >= 2)
                    return false;
                if ((square_5.Where(s => s.Equals(4)).Count()) >= 2)
                    return false;
                if ((square_5.Where(s => s.Equals(5)).Count()) >= 2)
                    return false;
                if ((square_5.Where(s => s.Equals(6)).Count()) >= 2)
                    return false;
                if ((square_5.Where(s => s.Equals(7)).Count()) >= 2)
                    return false;
                if ((square_5.Where(s => s.Equals(8)).Count()) >= 2)
                    return false;
                if ((square_5.Where(s => s.Equals(9)).Count()) >= 2)
                    return false;

                if ((square_6.Where(s => s.Equals(1)).Count()) >= 2)
                    return false;
                if ((square_6.Where(s => s.Equals(2)).Count()) >= 2)
                    return false;
                if ((square_6.Where(s => s.Equals(3)).Count()) >= 2)
                    return false;
                if ((square_6.Where(s => s.Equals(4)).Count()) >= 2)
                    return false;
                if ((square_6.Where(s => s.Equals(5)).Count()) >= 2)
                    return false;
                if ((square_6.Where(s => s.Equals(6)).Count()) >= 2)
                    return false;
                if ((square_6.Where(s => s.Equals(7)).Count()) >= 2)
                    return false;
                if ((square_6.Where(s => s.Equals(8)).Count()) >= 2)
                    return false;
                if ((square_6.Where(s => s.Equals(9)).Count()) >= 2)
                    return false;

                if ((square_7.Where(s => s.Equals(1)).Count()) >= 2)
                    return false;
                if ((square_7.Where(s => s.Equals(2)).Count()) >= 2)
                    return false;
                if ((square_7.Where(s => s.Equals(3)).Count()) >= 2)
                    return false;
                if ((square_7.Where(s => s.Equals(4)).Count()) >= 2)
                    return false;
                if ((square_7.Where(s => s.Equals(5)).Count()) >= 2)
                    return false;
                if ((square_7.Where(s => s.Equals(6)).Count()) >= 2)
                    return false;
                if ((square_7.Where(s => s.Equals(7)).Count()) >= 2)
                    return false;
                if ((square_7.Where(s => s.Equals(8)).Count()) >= 2)
                    return false;
                if ((square_7.Where(s => s.Equals(9)).Count()) >= 2)
                    return false;

                if ((square_8.Where(s => s.Equals(1)).Count()) >= 2)
                    return false;
                if ((square_8.Where(s => s.Equals(2)).Count()) >= 2)
                    return false;
                if ((square_8.Where(s => s.Equals(3)).Count()) >= 2)
                    return false;
                if ((square_8.Where(s => s.Equals(4)).Count()) >= 2)
                    return false;
                if ((square_8.Where(s => s.Equals(5)).Count()) >= 2)
                    return false;
                if ((square_8.Where(s => s.Equals(6)).Count()) >= 2)
                    return false;
                if ((square_8.Where(s => s.Equals(7)).Count()) >= 2)
                    return false;
                if ((square_8.Where(s => s.Equals(8)).Count()) >= 2)
                    return false;
                if ((square_8.Where(s => s.Equals(9)).Count()) >= 2)
                    return false;

                if ((square_9.Where(s => s.Equals(1)).Count()) >= 2)
                    return false;
                if ((square_9.Where(s => s.Equals(2)).Count()) >= 2)
                    return false;
                if ((square_9.Where(s => s.Equals(3)).Count()) >= 2)
                    return false;
                if ((square_9.Where(s => s.Equals(4)).Count()) >= 2)
                    return false;
                if ((square_9.Where(s => s.Equals(5)).Count()) >= 2)
                    return false;
                if ((square_9.Where(s => s.Equals(6)).Count()) >= 2)
                    return false;
                if ((square_9.Where(s => s.Equals(7)).Count()) >= 2)
                    return false;
                if ((square_9.Where(s => s.Equals(8)).Count()) >= 2)
                    return false;
                if ((square_9.Where(s => s.Equals(9)).Count()) >= 2)
                    return false;


                return true;
            }
            catch (Exception ex)
            {
                errorHandler(ex);
                return false;
            }
        }

        private bool check_vertical()
        {
            try
            {
                #region variables
                int column_1_1 = 0;
                int column_1_2 = 0;
                int column_1_3 = 0;
                int column_1_4 = 0;
                int column_1_5 = 0;
                int column_1_6 = 0;
                int column_1_7 = 0;
                int column_1_8 = 0;
                int column_1_9 = 0;
                int column_2_1 = 0;
                int column_2_2 = 0;
                int column_2_3 = 0;
                int column_2_4 = 0;
                int column_2_5 = 0;
                int column_2_6 = 0;
                int column_2_7 = 0;
                int column_2_8 = 0;
                int column_2_9 = 0;
                int column_3_1 = 0;
                int column_3_2 = 0;
                int column_3_3 = 0;
                int column_3_4 = 0;
                int column_3_5 = 0;
                int column_3_6 = 0;
                int column_3_7 = 0;
                int column_3_8 = 0;
                int column_3_9 = 0;
                int column_4_1 = 0;
                int column_4_2 = 0;
                int column_4_3 = 0;
                int column_4_4 = 0;
                int column_4_5 = 0;
                int column_4_6 = 0;
                int column_4_7 = 0;
                int column_4_8 = 0;
                int column_4_9 = 0;
                int column_5_1 = 0;
                int column_5_2 = 0;
                int column_5_3 = 0;
                int column_5_4 = 0;
                int column_5_5 = 0;
                int column_5_6 = 0;
                int column_5_7 = 0;
                int column_5_8 = 0;
                int column_5_9 = 0;
                int column_6_1 = 0;
                int column_6_2 = 0;
                int column_6_3 = 0;
                int column_6_4 = 0;
                int column_6_5 = 0;
                int column_6_6 = 0;
                int column_6_7 = 0;
                int column_6_8 = 0;
                int column_6_9 = 0;
                int column_7_1 = 0;
                int column_7_2 = 0;
                int column_7_3 = 0;
                int column_7_4 = 0;
                int column_7_5 = 0;
                int column_7_6 = 0;
                int column_7_7 = 0;
                int column_7_8 = 0;
                int column_7_9 = 0;
                int column_8_1 = 0;
                int column_8_2 = 0;
                int column_8_3 = 0;
                int column_8_4 = 0;
                int column_8_5 = 0;
                int column_8_6 = 0;
                int column_8_7 = 0;
                int column_8_8 = 0;
                int column_8_9 = 0;
                int column_9_1 = 0;
                int column_9_2 = 0;
                int column_9_3 = 0;
                int column_9_4 = 0;
                int column_9_5 = 0;
                int column_9_6 = 0;
                int column_9_7 = 0;
                int column_9_8 = 0;
                int column_9_9 = 0;
                #endregion

                List<int> column_1 = new List<int>();
                List<int> column_2 = new List<int>();
                List<int> column_3 = new List<int>();
                List<int> column_4 = new List<int>();
                List<int> column_5 = new List<int>();
                List<int> column_6 = new List<int>();
                List<int> column_7 = new List<int>();
                List<int> column_8 = new List<int>();
                List<int> column_9 = new List<int>();

                column_1.Add(tbx_1_number);
                column_1.Add(tbx_10_number);
                column_1.Add(tbx_19_number);
                column_1.Add(tbx_28_number);
                column_1.Add(tbx_37_number);
                column_1.Add(tbx_46_number);
                column_1.Add(tbx_55_number);
                column_1.Add(tbx_64_number);
                column_1.Add(tbx_73_number);

                column_2.Add(tbx_2_number);
                column_2.Add(tbx_11_number);
                column_2.Add(tbx_20_number);
                column_2.Add(tbx_29_number);
                column_2.Add(tbx_38_number);
                column_2.Add(tbx_47_number);
                column_2.Add(tbx_56_number);
                column_2.Add(tbx_65_number);
                column_2.Add(tbx_74_number);

                column_3.Add(tbx_3_number);
                column_3.Add(tbx_12_number);
                column_3.Add(tbx_21_number);
                column_3.Add(tbx_30_number);
                column_3.Add(tbx_39_number);
                column_3.Add(tbx_48_number);
                column_3.Add(tbx_57_number);
                column_3.Add(tbx_66_number);
                column_3.Add(tbx_75_number);

                column_4.Add(tbx_4_number);
                column_4.Add(tbx_13_number);
                column_4.Add(tbx_22_number);
                column_4.Add(tbx_31_number);
                column_4.Add(tbx_40_number);
                column_4.Add(tbx_49_number);
                column_4.Add(tbx_58_number);
                column_4.Add(tbx_67_number);
                column_4.Add(tbx_76_number);

                column_5.Add(tbx_5_number);
                column_5.Add(tbx_14_number);
                column_5.Add(tbx_23_number);
                column_5.Add(tbx_32_number);
                column_5.Add(tbx_41_number);
                column_5.Add(tbx_50_number);
                column_5.Add(tbx_59_number);
                column_5.Add(tbx_68_number);
                column_5.Add(tbx_77_number);

                column_6.Add(tbx_6_number);
                column_6.Add(tbx_15_number);
                column_6.Add(tbx_24_number);
                column_6.Add(tbx_33_number);
                column_6.Add(tbx_42_number);
                column_6.Add(tbx_51_number);
                column_6.Add(tbx_60_number);
                column_6.Add(tbx_69_number);
                column_6.Add(tbx_78_number);

                column_7.Add(tbx_7_number);
                column_7.Add(tbx_16_number);
                column_7.Add(tbx_25_number);
                column_7.Add(tbx_34_number);
                column_7.Add(tbx_43_number);
                column_7.Add(tbx_52_number);
                column_7.Add(tbx_61_number);
                column_7.Add(tbx_70_number);
                column_7.Add(tbx_79_number);

                column_8.Add(tbx_8_number);
                column_8.Add(tbx_17_number);
                column_8.Add(tbx_26_number);
                column_8.Add(tbx_35_number);
                column_8.Add(tbx_44_number);
                column_8.Add(tbx_53_number);
                column_8.Add(tbx_62_number);
                column_8.Add(tbx_71_number);
                column_8.Add(tbx_80_number);

                column_9.Add(tbx_9_number);
                column_9.Add(tbx_18_number);
                column_9.Add(tbx_27_number);
                column_9.Add(tbx_36_number);
                column_9.Add(tbx_45_number);
                column_9.Add(tbx_54_number);
                column_9.Add(tbx_63_number);
                column_9.Add(tbx_72_number);
                column_9.Add(tbx_81_number);

                if ((column_1.Where(s => s.Equals(1)).Count()) >= 2)
                    return false;
                if ((column_1.Where(s => s.Equals(2)).Count()) >= 2)
                    return false;
                if ((column_1.Where(s => s.Equals(3)).Count()) >= 2)
                    return false;
                if ((column_1.Where(s => s.Equals(4)).Count()) >= 2)
                    return false;
                if ((column_1.Where(s => s.Equals(5)).Count()) >= 2)
                    return false;
                if ((column_1.Where(s => s.Equals(6)).Count()) >= 2)
                    return false;
                if ((column_1.Where(s => s.Equals(7)).Count()) >= 2)
                    return false;
                if ((column_1.Where(s => s.Equals(8)).Count()) >= 2)
                    return false;
                if ((column_1.Where(s => s.Equals(9)).Count()) >= 2)
                    return false;

                if ((column_2.Where(s => s.Equals(1)).Count()) >= 2)
                    return false;
                if ((column_2.Where(s => s.Equals(2)).Count()) >= 2)
                    return false;
                if ((column_2.Where(s => s.Equals(3)).Count()) >= 2)
                    return false;
                if ((column_2.Where(s => s.Equals(4)).Count()) >= 2)
                    return false;
                if ((column_2.Where(s => s.Equals(5)).Count()) >= 2)
                    return false;
                if ((column_2.Where(s => s.Equals(6)).Count()) >= 2)
                    return false;
                if ((column_2.Where(s => s.Equals(7)).Count()) >= 2)
                    return false;
                if ((column_2.Where(s => s.Equals(8)).Count()) >= 2)
                    return false;
                if ((column_2.Where(s => s.Equals(9)).Count()) >= 2)
                    return false;

                if ((column_3.Where(s => s.Equals(1)).Count()) >= 2)
                    return false;
                if ((column_3.Where(s => s.Equals(2)).Count()) >= 2)
                    return false;
                if ((column_3.Where(s => s.Equals(3)).Count()) >= 2)
                    return false;
                if ((column_3.Where(s => s.Equals(4)).Count()) >= 2)
                    return false;
                if ((column_3.Where(s => s.Equals(5)).Count()) >= 2)
                    return false;
                if ((column_3.Where(s => s.Equals(6)).Count()) >= 2)
                    return false;
                if ((column_3.Where(s => s.Equals(7)).Count()) >= 2)
                    return false;
                if ((column_3.Where(s => s.Equals(8)).Count()) >= 2)
                    return false;
                if ((column_3.Where(s => s.Equals(9)).Count()) >= 2)
                    return false;

                if ((column_4.Where(s => s.Equals(1)).Count()) >= 2)
                    return false;
                if ((column_4.Where(s => s.Equals(2)).Count()) >= 2)
                    return false;
                if ((column_4.Where(s => s.Equals(3)).Count()) >= 2)
                    return false;
                if ((column_4.Where(s => s.Equals(4)).Count()) >= 2)
                    return false;
                if ((column_4.Where(s => s.Equals(5)).Count()) >= 2)
                    return false;
                if ((column_4.Where(s => s.Equals(6)).Count()) >= 2)
                    return false;
                if ((column_4.Where(s => s.Equals(7)).Count()) >= 2)
                    return false;
                if ((column_4.Where(s => s.Equals(8)).Count()) >= 2)
                    return false;
                if ((column_4.Where(s => s.Equals(9)).Count()) >= 2)
                    return false;

                if ((column_5.Where(s => s.Equals(1)).Count()) >= 2)
                    return false;
                if ((column_5.Where(s => s.Equals(2)).Count()) >= 2)
                    return false;
                if ((column_5.Where(s => s.Equals(3)).Count()) >= 2)
                    return false;
                if ((column_5.Where(s => s.Equals(4)).Count()) >= 2)
                    return false;
                if ((column_5.Where(s => s.Equals(5)).Count()) >= 2)
                    return false;
                if ((column_5.Where(s => s.Equals(6)).Count()) >= 2)
                    return false;
                if ((column_5.Where(s => s.Equals(7)).Count()) >= 2)
                    return false;
                if ((column_5.Where(s => s.Equals(8)).Count()) >= 2)
                    return false;
                if ((column_5.Where(s => s.Equals(9)).Count()) >= 2)
                    return false;

                if ((column_6.Where(s => s.Equals(1)).Count()) >= 2)
                    return false;
                if ((column_6.Where(s => s.Equals(2)).Count()) >= 2)
                    return false;
                if ((column_6.Where(s => s.Equals(3)).Count()) >= 2)
                    return false;
                if ((column_6.Where(s => s.Equals(4)).Count()) >= 2)
                    return false;
                if ((column_6.Where(s => s.Equals(5)).Count()) >= 2)
                    return false;
                if ((column_6.Where(s => s.Equals(6)).Count()) >= 2)
                    return false;
                if ((column_6.Where(s => s.Equals(7)).Count()) >= 2)
                    return false;
                if ((column_6.Where(s => s.Equals(8)).Count()) >= 2)
                    return false;
                if ((column_6.Where(s => s.Equals(9)).Count()) >= 2)
                    return false;

                if ((column_7.Where(s => s.Equals(1)).Count()) >= 2)
                    return false;
                if ((column_7.Where(s => s.Equals(2)).Count()) >= 2)
                    return false;
                if ((column_7.Where(s => s.Equals(3)).Count()) >= 2)
                    return false;
                if ((column_7.Where(s => s.Equals(4)).Count()) >= 2)
                    return false;
                if ((column_7.Where(s => s.Equals(5)).Count()) >= 2)
                    return false;
                if ((column_7.Where(s => s.Equals(6)).Count()) >= 2)
                    return false;
                if ((column_7.Where(s => s.Equals(7)).Count()) >= 2)
                    return false;
                if ((column_7.Where(s => s.Equals(8)).Count()) >= 2)
                    return false;
                if ((column_7.Where(s => s.Equals(9)).Count()) >= 2)
                    return false;

                if ((column_8.Where(s => s.Equals(1)).Count()) >= 2)
                    return false;
                if ((column_8.Where(s => s.Equals(2)).Count()) >= 2)
                    return false;
                if ((column_8.Where(s => s.Equals(3)).Count()) >= 2)
                    return false;
                if ((column_8.Where(s => s.Equals(4)).Count()) >= 2)
                    return false;
                if ((column_8.Where(s => s.Equals(5)).Count()) >= 2)
                    return false;
                if ((column_8.Where(s => s.Equals(6)).Count()) >= 2)
                    return false;
                if ((column_8.Where(s => s.Equals(7)).Count()) >= 2)
                    return false;
                if ((column_8.Where(s => s.Equals(8)).Count()) >= 2)
                    return false;
                if ((column_8.Where(s => s.Equals(9)).Count()) >= 2)
                    return false;

                if ((column_9.Where(s => s.Equals(1)).Count()) >= 2)
                    return false;
                if ((column_9.Where(s => s.Equals(2)).Count()) >= 2)
                    return false;
                if ((column_9.Where(s => s.Equals(3)).Count()) >= 2)
                    return false;
                if ((column_9.Where(s => s.Equals(4)).Count()) >= 2)
                    return false;
                if ((column_9.Where(s => s.Equals(5)).Count()) >= 2)
                    return false;
                if ((column_9.Where(s => s.Equals(6)).Count()) >= 2)
                    return false;
                if ((column_9.Where(s => s.Equals(7)).Count()) >= 2)
                    return false;
                if ((column_9.Where(s => s.Equals(8)).Count()) >= 2)
                    return false;
                if ((column_9.Where(s => s.Equals(9)).Count()) >= 2)
                    return false;


                return true;
            }
            catch (Exception ex)
            {
                errorHandler(ex);
                return false;
            }
        }

        private bool check_horizontal()
        {
            try
            {
                #region variables
                int row_1_1 = 0;
                int row_1_2 = 0;
                int row_1_3 = 0;
                int row_1_4 = 0;
                int row_1_5 = 0;
                int row_1_6 = 0;
                int row_1_7 = 0;
                int row_1_8 = 0;
                int row_1_9 = 0;
                int row_2_1 = 0;
                int row_2_2 = 0;
                int row_2_3 = 0;
                int row_2_4 = 0;
                int row_2_5 = 0;
                int row_2_6 = 0;
                int row_2_7 = 0;
                int row_2_8 = 0;
                int row_2_9 = 0;
                int row_3_1 = 0;
                int row_3_2 = 0;
                int row_3_3 = 0;
                int row_3_4 = 0;
                int row_3_5 = 0;
                int row_3_6 = 0;
                int row_3_7 = 0;
                int row_3_8 = 0;
                int row_3_9 = 0;
                int row_4_1 = 0;
                int row_4_2 = 0;
                int row_4_3 = 0;
                int row_4_4 = 0;
                int row_4_5 = 0;
                int row_4_6 = 0;
                int row_4_7 = 0;
                int row_4_8 = 0;
                int row_4_9 = 0;
                int row_5_1 = 0;
                int row_5_2 = 0;
                int row_5_3 = 0;
                int row_5_4 = 0;
                int row_5_5 = 0;
                int row_5_6 = 0;
                int row_5_7 = 0;
                int row_5_8 = 0;
                int row_5_9 = 0;
                int row_6_1 = 0;
                int row_6_2 = 0;
                int row_6_3 = 0;
                int row_6_4 = 0;
                int row_6_5 = 0;
                int row_6_6 = 0;
                int row_6_7 = 0;
                int row_6_8 = 0;
                int row_6_9 = 0;
                int row_7_1 = 0;
                int row_7_2 = 0;
                int row_7_3 = 0;
                int row_7_4 = 0;
                int row_7_5 = 0;
                int row_7_6 = 0;
                int row_7_7 = 0;
                int row_7_8 = 0;
                int row_7_9 = 0;
                int row_8_1 = 0;
                int row_8_2 = 0;
                int row_8_3 = 0;
                int row_8_4 = 0;
                int row_8_5 = 0;
                int row_8_6 = 0;
                int row_8_7 = 0;
                int row_8_8 = 0;
                int row_8_9 = 0;
                int row_9_1 = 0;
                int row_9_2 = 0;
                int row_9_3 = 0;
                int row_9_4 = 0;
                int row_9_5 = 0;
                int row_9_6 = 0;
                int row_9_7 = 0;
                int row_9_8 = 0;
                int row_9_9 = 0;
                #endregion

                List<int> row_1 = new List<int>();
                List<int> row_2 = new List<int>();
                List<int> row_3 = new List<int>();
                List<int> row_4 = new List<int>();
                List<int> row_5 = new List<int>();
                List<int> row_6 = new List<int>();
                List<int> row_7 = new List<int>();
                List<int> row_8 = new List<int>();
                List<int> row_9 = new List<int>();

                row_1.Add(tbx_1_number);
                row_1.Add(tbx_2_number);
                row_1.Add(tbx_3_number);
                row_1.Add(tbx_4_number);
                row_1.Add(tbx_5_number);
                row_1.Add(tbx_6_number);
                row_1.Add(tbx_7_number);
                row_1.Add(tbx_8_number);
                row_1.Add(tbx_9_number);

                row_2.Add(tbx_10_number);
                row_2.Add(tbx_11_number);
                row_2.Add(tbx_12_number);
                row_2.Add(tbx_13_number);
                row_2.Add(tbx_14_number);
                row_2.Add(tbx_15_number);
                row_2.Add(tbx_16_number);
                row_2.Add(tbx_17_number);
                row_2.Add(tbx_18_number);

                row_3.Add(tbx_19_number);
                row_3.Add(tbx_20_number);
                row_3.Add(tbx_21_number);
                row_3.Add(tbx_22_number);
                row_3.Add(tbx_23_number);
                row_3.Add(tbx_24_number);
                row_3.Add(tbx_25_number);
                row_3.Add(tbx_26_number);
                row_3.Add(tbx_27_number);

                row_4.Add(tbx_28_number);
                row_4.Add(tbx_29_number);
                row_4.Add(tbx_30_number);
                row_4.Add(tbx_31_number);
                row_4.Add(tbx_32_number);
                row_4.Add(tbx_33_number);
                row_4.Add(tbx_34_number);
                row_4.Add(tbx_35_number);
                row_4.Add(tbx_36_number);

                row_5.Add(tbx_37_number);
                row_5.Add(tbx_38_number);
                row_5.Add(tbx_39_number);
                row_5.Add(tbx_40_number);
                row_5.Add(tbx_41_number);
                row_5.Add(tbx_42_number);
                row_5.Add(tbx_43_number);
                row_5.Add(tbx_44_number);
                row_5.Add(tbx_45_number);

                row_6.Add(tbx_46_number);
                row_6.Add(tbx_47_number);
                row_6.Add(tbx_48_number);
                row_6.Add(tbx_49_number);
                row_6.Add(tbx_50_number);
                row_6.Add(tbx_51_number);
                row_6.Add(tbx_52_number);
                row_6.Add(tbx_53_number);
                row_6.Add(tbx_54_number);

                row_7.Add(tbx_55_number);
                row_7.Add(tbx_56_number);
                row_7.Add(tbx_57_number);
                row_7.Add(tbx_58_number);
                row_7.Add(tbx_59_number);
                row_7.Add(tbx_60_number);
                row_7.Add(tbx_61_number);
                row_7.Add(tbx_62_number);
                row_7.Add(tbx_63_number);

                row_8.Add(tbx_64_number);
                row_8.Add(tbx_65_number);
                row_8.Add(tbx_66_number);
                row_8.Add(tbx_67_number);
                row_8.Add(tbx_68_number);
                row_8.Add(tbx_69_number);
                row_8.Add(tbx_70_number);
                row_8.Add(tbx_71_number);
                row_8.Add(tbx_72_number);

                row_9.Add(tbx_73_number);
                row_9.Add(tbx_74_number);
                row_9.Add(tbx_75_number);
                row_9.Add(tbx_76_number);
                row_9.Add(tbx_77_number);
                row_9.Add(tbx_78_number);
                row_9.Add(tbx_79_number);
                row_9.Add(tbx_80_number);
                row_9.Add(tbx_81_number);

                if ((row_1.Where(s => s.Equals(1)).Count()) >= 2)
                    return false;
                if ((row_1.Where(s => s.Equals(2)).Count()) >= 2)
                    return false;
                if ((row_1.Where(s => s.Equals(3)).Count()) >= 2)
                    return false;
                if ((row_1.Where(s => s.Equals(4)).Count()) >= 2)
                    return false;
                if ((row_1.Where(s => s.Equals(5)).Count()) >= 2)
                    return false;
                if ((row_1.Where(s => s.Equals(6)).Count()) >= 2)
                    return false;
                if ((row_1.Where(s => s.Equals(7)).Count()) >= 2)
                    return false;
                if ((row_1.Where(s => s.Equals(8)).Count()) >= 2)
                    return false;
                if ((row_1.Where(s => s.Equals(9)).Count()) >= 2)
                    return false;

                if ((row_2.Where(s => s.Equals(1)).Count()) >= 2)
                    return false;
                if ((row_2.Where(s => s.Equals(2)).Count()) >= 2)
                    return false;
                if ((row_2.Where(s => s.Equals(3)).Count()) >= 2)
                    return false;
                if ((row_2.Where(s => s.Equals(4)).Count()) >= 2)
                    return false;
                if ((row_2.Where(s => s.Equals(5)).Count()) >= 2)
                    return false;
                if ((row_2.Where(s => s.Equals(6)).Count()) >= 2)
                    return false;
                if ((row_2.Where(s => s.Equals(7)).Count()) >= 2)
                    return false;
                if ((row_2.Where(s => s.Equals(8)).Count()) >= 2)
                    return false;
                if ((row_2.Where(s => s.Equals(9)).Count()) >= 2)
                    return false;

                if ((row_3.Where(s => s.Equals(1)).Count()) >= 2)
                    return false;
                if ((row_3.Where(s => s.Equals(2)).Count()) >= 2)
                    return false;
                if ((row_3.Where(s => s.Equals(3)).Count()) >= 2)
                    return false;
                if ((row_3.Where(s => s.Equals(4)).Count()) >= 2)
                    return false;
                if ((row_3.Where(s => s.Equals(5)).Count()) >= 2)
                    return false;
                if ((row_3.Where(s => s.Equals(6)).Count()) >= 2)
                    return false;
                if ((row_3.Where(s => s.Equals(7)).Count()) >= 2)
                    return false;
                if ((row_3.Where(s => s.Equals(8)).Count()) >= 2)
                    return false;
                if ((row_3.Where(s => s.Equals(9)).Count()) >= 2)
                    return false;

                if ((row_4.Where(s => s.Equals(1)).Count()) >= 2)
                    return false;
                if ((row_4.Where(s => s.Equals(2)).Count()) >= 2)
                    return false;
                if ((row_4.Where(s => s.Equals(3)).Count()) >= 2)
                    return false;
                if ((row_4.Where(s => s.Equals(4)).Count()) >= 2)
                    return false;
                if ((row_4.Where(s => s.Equals(5)).Count()) >= 2)
                    return false;
                if ((row_4.Where(s => s.Equals(6)).Count()) >= 2)
                    return false;
                if ((row_4.Where(s => s.Equals(7)).Count()) >= 2)
                    return false;
                if ((row_4.Where(s => s.Equals(8)).Count()) >= 2)
                    return false;
                if ((row_4.Where(s => s.Equals(9)).Count()) >= 2)
                    return false;

                if ((row_5.Where(s => s.Equals(1)).Count()) >= 2)
                    return false;
                if ((row_5.Where(s => s.Equals(2)).Count()) >= 2)
                    return false;
                if ((row_5.Where(s => s.Equals(3)).Count()) >= 2)
                    return false;
                if ((row_5.Where(s => s.Equals(4)).Count()) >= 2)
                    return false;
                if ((row_5.Where(s => s.Equals(5)).Count()) >= 2)
                    return false;
                if ((row_5.Where(s => s.Equals(6)).Count()) >= 2)
                    return false;
                if ((row_5.Where(s => s.Equals(7)).Count()) >= 2)
                    return false;
                if ((row_5.Where(s => s.Equals(8)).Count()) >= 2)
                    return false;
                if ((row_5.Where(s => s.Equals(9)).Count()) >= 2)
                    return false;

                if ((row_6.Where(s => s.Equals(1)).Count()) >= 2)
                    return false;
                if ((row_6.Where(s => s.Equals(2)).Count()) >= 2)
                    return false;
                if ((row_6.Where(s => s.Equals(3)).Count()) >= 2)
                    return false;
                if ((row_6.Where(s => s.Equals(4)).Count()) >= 2)
                    return false;
                if ((row_6.Where(s => s.Equals(5)).Count()) >= 2)
                    return false;
                if ((row_6.Where(s => s.Equals(6)).Count()) >= 2)
                    return false;
                if ((row_6.Where(s => s.Equals(7)).Count()) >= 2)
                    return false;
                if ((row_6.Where(s => s.Equals(8)).Count()) >= 2)
                    return false;
                if ((row_6.Where(s => s.Equals(9)).Count()) >= 2)
                    return false;

                if ((row_7.Where(s => s.Equals(1)).Count()) >= 2)
                    return false;
                if ((row_7.Where(s => s.Equals(2)).Count()) >= 2)
                    return false;
                if ((row_7.Where(s => s.Equals(3)).Count()) >= 2)
                    return false;
                if ((row_7.Where(s => s.Equals(4)).Count()) >= 2)
                    return false;
                if ((row_7.Where(s => s.Equals(5)).Count()) >= 2)
                    return false;
                if ((row_7.Where(s => s.Equals(6)).Count()) >= 2)
                    return false;
                if ((row_7.Where(s => s.Equals(7)).Count()) >= 2)
                    return false;
                if ((row_7.Where(s => s.Equals(8)).Count()) >= 2)
                    return false;
                if ((row_7.Where(s => s.Equals(9)).Count()) >= 2)
                    return false;

                if ((row_8.Where(s => s.Equals(1)).Count()) >= 2)
                    return false;
                if ((row_8.Where(s => s.Equals(2)).Count()) >= 2)
                    return false;
                if ((row_8.Where(s => s.Equals(3)).Count()) >= 2)
                    return false;
                if ((row_8.Where(s => s.Equals(4)).Count()) >= 2)
                    return false;
                if ((row_8.Where(s => s.Equals(5)).Count()) >= 2)
                    return false;
                if ((row_8.Where(s => s.Equals(6)).Count()) >= 2)
                    return false;
                if ((row_8.Where(s => s.Equals(7)).Count()) >= 2)
                    return false;
                if ((row_8.Where(s => s.Equals(8)).Count()) >= 2)
                    return false;
                if ((row_8.Where(s => s.Equals(9)).Count()) >= 2)
                    return false;

                if ((row_9.Where(s => s.Equals(1)).Count()) >= 2)
                    return false;
                if ((row_9.Where(s => s.Equals(2)).Count()) >= 2)
                    return false;
                if ((row_9.Where(s => s.Equals(3)).Count()) >= 2)
                    return false;
                if ((row_9.Where(s => s.Equals(4)).Count()) >= 2)
                    return false;
                if ((row_9.Where(s => s.Equals(5)).Count()) >= 2)
                    return false;
                if ((row_9.Where(s => s.Equals(6)).Count()) >= 2)
                    return false;
                if ((row_9.Where(s => s.Equals(7)).Count()) >= 2)
                    return false;
                if ((row_9.Where(s => s.Equals(8)).Count()) >= 2)
                    return false;
                if ((row_9.Where(s => s.Equals(9)).Count()) >= 2)
                    return false;


                return true;
            }
            catch (Exception ex)
            {
                errorHandler(ex);
                return false;
            }
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            try
            {
                currentResultIndex--;
                int currentPage = currentResultIndex + 1;
                lbl_currentPage.Text = currentPage.ToString();
                btn_next.Enabled = true;

                if (currentResultIndex > 0)
                {
                    displayResult(currentResultIndex);
                }
                else
                {
                    displayResult(currentResultIndex);
                    btn_previous.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            try
            {
                currentResultIndex++;
                int currentPage = currentResultIndex + 1;
                lbl_currentPage.Text = currentPage.ToString();
                btn_previous.Enabled = true;

                if (currentResultIndex < numberOfResults-1)
                {
                    displayResult(currentResultIndex);
                }
                else
                {
                    displayResult(currentResultIndex);
                    btn_next.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void displayResult(int index)
        {
            try
            {
                tbx_1.Text = "" + sudokuGrids[index].square_1;
                tbx_2.Text = "" + sudokuGrids[index].square_2;
                tbx_3.Text = "" + sudokuGrids[index].square_3;
                tbx_4.Text = "" + sudokuGrids[index].square_4;
                tbx_5.Text = "" + sudokuGrids[index].square_5;
                tbx_6.Text = "" + sudokuGrids[index].square_6;
                tbx_7.Text = "" + sudokuGrids[index].square_7;
                tbx_8.Text = "" + sudokuGrids[index].square_8;
                tbx_9.Text = "" + sudokuGrids[index].square_9;
                tbx_10.Text = "" + sudokuGrids[index].square_10;
                tbx_11.Text = "" + sudokuGrids[index].square_11;
                tbx_12.Text = "" + sudokuGrids[index].square_12;
                tbx_13.Text = "" + sudokuGrids[index].square_13;
                tbx_14.Text = "" + sudokuGrids[index].square_14;
                tbx_15.Text = "" + sudokuGrids[index].square_15;
                tbx_16.Text = "" + sudokuGrids[index].square_16;
                tbx_17.Text = "" + sudokuGrids[index].square_17;
                tbx_18.Text = "" + sudokuGrids[index].square_18;
                tbx_19.Text = "" + sudokuGrids[index].square_19;
                tbx_20.Text = "" + sudokuGrids[index].square_20;
                tbx_21.Text = "" + sudokuGrids[index].square_21;
                tbx_22.Text = "" + sudokuGrids[index].square_22;
                tbx_23.Text = "" + sudokuGrids[index].square_23;
                tbx_24.Text = "" + sudokuGrids[index].square_24;
                tbx_25.Text = "" + sudokuGrids[index].square_25;
                tbx_26.Text = "" + sudokuGrids[index].square_26;
                tbx_27.Text = "" + sudokuGrids[index].square_27;
                tbx_28.Text = "" + sudokuGrids[index].square_28;
                tbx_29.Text = "" + sudokuGrids[index].square_29;
                tbx_30.Text = "" + sudokuGrids[index].square_30;
                tbx_31.Text = "" + sudokuGrids[index].square_31;
                tbx_32.Text = "" + sudokuGrids[index].square_32;
                tbx_33.Text = "" + sudokuGrids[index].square_33;
                tbx_34.Text = "" + sudokuGrids[index].square_34;
                tbx_35.Text = "" + sudokuGrids[index].square_35;
                tbx_36.Text = "" + sudokuGrids[index].square_36;
                tbx_37.Text = "" + sudokuGrids[index].square_37;
                tbx_38.Text = "" + sudokuGrids[index].square_38;
                tbx_39.Text = "" + sudokuGrids[index].square_39;
                tbx_40.Text = "" + sudokuGrids[index].square_40;
                tbx_41.Text = "" + sudokuGrids[index].square_41;
                tbx_42.Text = "" + sudokuGrids[index].square_42;
                tbx_43.Text = "" + sudokuGrids[index].square_43;
                tbx_44.Text = "" + sudokuGrids[index].square_44;
                tbx_45.Text = "" + sudokuGrids[index].square_45;
                tbx_46.Text = "" + sudokuGrids[index].square_46;
                tbx_47.Text = "" + sudokuGrids[index].square_47;
                tbx_48.Text = "" + sudokuGrids[index].square_48;
                tbx_49.Text = "" + sudokuGrids[index].square_49;
                tbx_50.Text = "" + sudokuGrids[index].square_50;
                tbx_51.Text = "" + sudokuGrids[index].square_51;
                tbx_52.Text = "" + sudokuGrids[index].square_52;
                tbx_53.Text = "" + sudokuGrids[index].square_53;
                tbx_54.Text = "" + sudokuGrids[index].square_54;
                tbx_55.Text = "" + sudokuGrids[index].square_55;
                tbx_56.Text = "" + sudokuGrids[index].square_56;
                tbx_57.Text = "" + sudokuGrids[index].square_57;
                tbx_58.Text = "" + sudokuGrids[index].square_58;
                tbx_59.Text = "" + sudokuGrids[index].square_59;
                tbx_60.Text = "" + sudokuGrids[index].square_60;
                tbx_61.Text = "" + sudokuGrids[index].square_61;
                tbx_62.Text = "" + sudokuGrids[index].square_62;
                tbx_63.Text = "" + sudokuGrids[index].square_63;
                tbx_64.Text = "" + sudokuGrids[index].square_64;
                tbx_65.Text = "" + sudokuGrids[index].square_65;
                tbx_66.Text = "" + sudokuGrids[index].square_66;
                tbx_67.Text = "" + sudokuGrids[index].square_67;
                tbx_68.Text = "" + sudokuGrids[index].square_68;
                tbx_69.Text = "" + sudokuGrids[index].square_69;
                tbx_70.Text = "" + sudokuGrids[index].square_70;
                tbx_71.Text = "" + sudokuGrids[index].square_71;
                tbx_72.Text = "" + sudokuGrids[index].square_72;
                tbx_73.Text = "" + sudokuGrids[index].square_73;
                tbx_74.Text = "" + sudokuGrids[index].square_74;
                tbx_75.Text = "" + sudokuGrids[index].square_75;
                tbx_76.Text = "" + sudokuGrids[index].square_76;
                tbx_77.Text = "" + sudokuGrids[index].square_77;
                tbx_78.Text = "" + sudokuGrids[index].square_78;
                tbx_79.Text = "" + sudokuGrids[index].square_79;
                tbx_80.Text = "" + sudokuGrids[index].square_80;
                tbx_81.Text = "" + sudokuGrids[index].square_81;
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

    }
}