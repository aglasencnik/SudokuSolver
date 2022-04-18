using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SudokuSolver
{
    public class sudokuSolver
    {
        private int[][] grid;
        private List<int[][]> solvedGrids;
        private List<string> solutions;

        public sudokuSolver(sudokuGrid _grid)
        {
            try
            {
                solvedGrids = new List<int[][]>();
                solutions = new List<string>();
                grid = new int[9][];
                grid[0] = new int[] { _grid.square_1, _grid.square_2, _grid.square_3, _grid.square_4, _grid.square_5, _grid.square_6, _grid.square_7, _grid.square_8, _grid.square_9 };
                grid[1] = new int[] { _grid.square_10, _grid.square_11, _grid.square_12, _grid.square_13, _grid.square_14, _grid.square_15, _grid.square_16, _grid.square_17, _grid.square_18 };
                grid[2] = new int[] { _grid.square_19, _grid.square_20, _grid.square_21, _grid.square_22, _grid.square_23, _grid.square_24, _grid.square_25, _grid.square_26, _grid.square_27 };
                grid[3] = new int[] { _grid.square_28, _grid.square_29, _grid.square_30, _grid.square_31, _grid.square_32, _grid.square_33, _grid.square_34, _grid.square_35, _grid.square_36 };
                grid[4] = new int[] { _grid.square_37, _grid.square_38, _grid.square_39, _grid.square_40, _grid.square_41, _grid.square_42, _grid.square_43, _grid.square_44, _grid.square_45 };
                grid[5] = new int[] { _grid.square_46, _grid.square_47, _grid.square_48, _grid.square_49, _grid.square_50, _grid.square_51, _grid.square_52, _grid.square_53, _grid.square_54 };
                grid[6] = new int[] { _grid.square_55, _grid.square_56, _grid.square_57, _grid.square_58, _grid.square_59, _grid.square_60, _grid.square_61, _grid.square_62, _grid.square_63 };
                grid[7] = new int[] { _grid.square_64, _grid.square_65, _grid.square_66, _grid.square_67, _grid.square_68, _grid.square_69, _grid.square_70, _grid.square_71, _grid.square_72 };
                grid[8] = new int[] { _grid.square_73, _grid.square_74, _grid.square_75, _grid.square_76, _grid.square_77, _grid.square_78, _grid.square_79, _grid.square_80, _grid.square_81 };
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

        public sudokuGrid[] solve()
        {
            sudokuGrid[] results;
            try
            {
                solveSudoku();
                results = new sudokuGrid[solutions.Count];
                for (int i = 0; i < solutions.Count; i++)
                {
                    int[][] grid2 = DeserializeXmlToGrid(solutions[i]);
                    results[i] = serializeGrid(grid2);
                }
                return results;
            }
            catch (Exception ex)
            {
                errorHandler(ex);
                results = new sudokuGrid[0];
                return results;
            }
        }

        private void solveSudoku()
        {
            try
            {
                for (int y = 0; y < 9; y++)
                {
                    for (int x = 0; x < 9; x++)
                    {
                        if (grid[y][x] == 0)
                        {
                            for (int n = 1; n < 10; n++)
                            {
                                if (possible(y, x, n))
                                {
                                    grid[y][x] = n;
                                    solveSudoku();
                                    grid[y][x] = 0;
                                }
                            }
                            return;
                        }
                    }
                }
                SerializeGridToXmlString(grid);
                //solvedGrids.Add(grid);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private bool possible(int y, int x, int n)
        {
            try
            {
                for (int i = 0; i < 9; i++)
                {
                    if (grid[y][i] == n)
                        return false;
                }
                for (int i = 0; i < 9; i++)
                {
                    if (grid[i][x] == n)
                        return false;
                }
                double x0d = x / 3;
                double y0d = y / 3;
                int x0 = (Convert.ToInt32(Math.Floor(x0d))) * 3;
                int y0 = (Convert.ToInt32(Math.Floor(y0d))) * 3;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (grid[y0 + i][x0 + j] == n)
                            return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                errorHandler(ex);
                return false;
            }
        }

        private sudokuGrid serializeGrid(int[][] _grid)
        {
            sudokuGrid serializedGrid = new sudokuGrid();
            try
            {
                serializedGrid.square_1 = _grid[0][0];
                serializedGrid.square_2 = _grid[0][1];
                serializedGrid.square_3 = _grid[0][2];
                serializedGrid.square_4 = _grid[0][3];
                serializedGrid.square_5 = _grid[0][4];
                serializedGrid.square_6 = _grid[0][5];
                serializedGrid.square_7 = _grid[0][6];
                serializedGrid.square_8 = _grid[0][7];
                serializedGrid.square_9 = _grid[0][8];
                serializedGrid.square_10 = _grid[1][0];
                serializedGrid.square_11 = _grid[1][1];
                serializedGrid.square_12 = _grid[1][2];
                serializedGrid.square_13 = _grid[1][3];
                serializedGrid.square_14 = _grid[1][4];
                serializedGrid.square_15 = _grid[1][5];
                serializedGrid.square_16 = _grid[1][6];
                serializedGrid.square_17 = _grid[1][7];
                serializedGrid.square_18 = _grid[1][8];
                serializedGrid.square_19 = _grid[2][0];
                serializedGrid.square_20 = _grid[2][1];
                serializedGrid.square_21 = _grid[2][2];
                serializedGrid.square_22 = _grid[2][3];
                serializedGrid.square_23 = _grid[2][4];
                serializedGrid.square_24 = _grid[2][5];
                serializedGrid.square_25 = _grid[2][6];
                serializedGrid.square_26 = _grid[2][7];
                serializedGrid.square_27 = _grid[2][8];
                serializedGrid.square_28 = _grid[3][0];
                serializedGrid.square_29 = _grid[3][1];
                serializedGrid.square_30 = _grid[3][2];
                serializedGrid.square_31 = _grid[3][3];
                serializedGrid.square_32 = _grid[3][4];
                serializedGrid.square_33 = _grid[3][5];
                serializedGrid.square_34 = _grid[3][6];
                serializedGrid.square_35 = _grid[3][7];
                serializedGrid.square_36 = _grid[3][8];
                serializedGrid.square_37 = _grid[4][0];
                serializedGrid.square_38 = _grid[4][1];
                serializedGrid.square_39 = _grid[4][2];
                serializedGrid.square_40 = _grid[4][3];
                serializedGrid.square_41 = _grid[4][4];
                serializedGrid.square_42 = _grid[4][5];
                serializedGrid.square_43 = _grid[4][6];
                serializedGrid.square_44 = _grid[4][7];
                serializedGrid.square_45 = _grid[4][8];
                serializedGrid.square_46 = _grid[5][0];
                serializedGrid.square_47 = _grid[5][1];
                serializedGrid.square_48 = _grid[5][2];
                serializedGrid.square_49 = _grid[5][3];
                serializedGrid.square_50 = _grid[5][4];
                serializedGrid.square_51 = _grid[5][5];
                serializedGrid.square_52 = _grid[5][6];
                serializedGrid.square_53 = _grid[5][7];
                serializedGrid.square_54 = _grid[5][8];
                serializedGrid.square_55 = _grid[6][0];
                serializedGrid.square_56 = _grid[6][1];
                serializedGrid.square_57 = _grid[6][2];
                serializedGrid.square_58 = _grid[6][3];
                serializedGrid.square_59 = _grid[6][4];
                serializedGrid.square_60 = _grid[6][5];
                serializedGrid.square_61 = _grid[6][6];
                serializedGrid.square_62 = _grid[6][7];
                serializedGrid.square_63 = _grid[6][8];
                serializedGrid.square_64 = _grid[7][0];
                serializedGrid.square_65 = _grid[7][1];
                serializedGrid.square_66 = _grid[7][2];
                serializedGrid.square_67 = _grid[7][3];
                serializedGrid.square_68 = _grid[7][4];
                serializedGrid.square_69 = _grid[7][5];
                serializedGrid.square_70 = _grid[7][6];
                serializedGrid.square_71 = _grid[7][7];
                serializedGrid.square_72 = _grid[7][8];
                serializedGrid.square_73 = _grid[8][0];
                serializedGrid.square_74 = _grid[8][1];
                serializedGrid.square_75 = _grid[8][2];
                serializedGrid.square_76 = _grid[8][3];
                serializedGrid.square_77 = _grid[8][4];
                serializedGrid.square_78 = _grid[8][5];
                serializedGrid.square_79 = _grid[8][6];
                serializedGrid.square_80 = _grid[8][7];
                serializedGrid.square_81 = _grid[8][8];
                return serializedGrid;
            }
            catch (Exception ex)
            {
                errorHandler(ex);
                return serializedGrid;
            }
        }

        private void SerializeGridToXmlString(int[][] _grid)
        {
            try
            {
                sudokuGrid serializedGrid = new sudokuGrid
                {
                    square_1 = _grid[0][0],
                    square_2 = _grid[0][1],
                    square_3 = _grid[0][2],
                    square_4 = _grid[0][3],
                    square_5 = _grid[0][4],
                    square_6 = _grid[0][5],
                    square_7 = _grid[0][6],
                    square_8 = _grid[0][7],
                    square_9 = _grid[0][8],
                    square_10 = _grid[1][0],
                    square_11 = _grid[1][1],
                    square_12 = _grid[1][2],
                    square_13 = _grid[1][3],
                    square_14 = _grid[1][4],
                    square_15 = _grid[1][5],
                    square_16 = _grid[1][6],
                    square_17 = _grid[1][7],
                    square_18 = _grid[1][8],
                    square_19 = _grid[2][0],
                    square_20 = _grid[2][1],
                    square_21 = _grid[2][2],
                    square_22 = _grid[2][3],
                    square_23 = _grid[2][4],
                    square_24 = _grid[2][5],
                    square_25 = _grid[2][6],
                    square_26 = _grid[2][7],
                    square_27 = _grid[2][8],
                    square_28 = _grid[3][0],
                    square_29 = _grid[3][1],
                    square_30 = _grid[3][2],
                    square_31 = _grid[3][3],
                    square_32 = _grid[3][4],
                    square_33 = _grid[3][5],
                    square_34 = _grid[3][6],
                    square_35 = _grid[3][7],
                    square_36 = _grid[3][8],
                    square_37 = _grid[4][0],
                    square_38 = _grid[4][1],
                    square_39 = _grid[4][2],
                    square_40 = _grid[4][3],
                    square_41 = _grid[4][4],
                    square_42 = _grid[4][5],
                    square_43 = _grid[4][6],
                    square_44 = _grid[4][7],
                    square_45 = _grid[4][8],
                    square_46 = _grid[5][0],
                    square_47 = _grid[5][1],
                    square_48 = _grid[5][2],
                    square_49 = _grid[5][3],
                    square_50 = _grid[5][4],
                    square_51 = _grid[5][5],
                    square_52 = _grid[5][6],
                    square_53 = _grid[5][7],
                    square_54 = _grid[5][8],
                    square_55 = _grid[6][0],
                    square_56 = _grid[6][1],
                    square_57 = _grid[6][2],
                    square_58 = _grid[6][3],
                    square_59 = _grid[6][4],
                    square_60 = _grid[6][5],
                    square_61 = _grid[6][6],
                    square_62 = _grid[6][7],
                    square_63 = _grid[6][8],
                    square_64 = _grid[7][0],
                    square_65 = _grid[7][1],
                    square_66 = _grid[7][2],
                    square_67 = _grid[7][3],
                    square_68 = _grid[7][4],
                    square_69 = _grid[7][5],
                    square_70 = _grid[7][6],
                    square_71 = _grid[7][7],
                    square_72 = _grid[7][8],
                    square_73 = _grid[8][0],
                    square_74 = _grid[8][1],
                    square_75 = _grid[8][2],
                    square_76 = _grid[8][3],
                    square_77 = _grid[8][4],
                    square_78 = _grid[8][5],
                    square_79 = _grid[8][6],
                    square_80 = _grid[8][7],
                    square_81 = _grid[8][8]
                };

                var xmlSerializer = new XmlSerializer(typeof(sudokuGrid));
                using (var writer = new StringWriter())
                {
                    xmlSerializer.Serialize(writer, serializedGrid);
                    var xmlContent = writer.ToString();
                    solutions.Add(xmlContent);
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private int[][] DeserializeXmlToGrid(string solution)
        {
            int[][] _grid;
            try
            {
                _grid = new int[9][];
                _grid[0] = new int[9];
                _grid[1] = new int[9];
                _grid[2] = new int[9];
                _grid[3] = new int[9];
                _grid[4] = new int[9];
                _grid[5] = new int[9];
                _grid[6] = new int[9];
                _grid[7] = new int[9];
                _grid[8] = new int[9];
                XmlSerializer serializer = new XmlSerializer(typeof(sudokuGrid));
                using (TextReader reader = new StringReader(solution))
                {
                    sudokuGrid result = (sudokuGrid)serializer.Deserialize(reader);
                    _grid[0][0] = result.square_1;
                    _grid[0][1] = result.square_2;
                    _grid[0][2] = result.square_3;
                    _grid[0][3] = result.square_4;
                    _grid[0][4] = result.square_5;
                    _grid[0][5] = result.square_6;
                    _grid[0][6] = result.square_7;
                    _grid[0][7] = result.square_8;
                    _grid[0][8] = result.square_9;
                    _grid[1][0] = result.square_10;
                    _grid[1][1] = result.square_11;
                    _grid[1][2] = result.square_12;
                    _grid[1][3] = result.square_13;
                    _grid[1][4] = result.square_14;
                    _grid[1][5] = result.square_15;
                    _grid[1][6] = result.square_16;
                    _grid[1][7] = result.square_17;
                    _grid[1][8] = result.square_18;
                    _grid[2][0] = result.square_19;
                    _grid[2][1] = result.square_20;
                    _grid[2][2] = result.square_21;
                    _grid[2][3] = result.square_22;
                    _grid[2][4] = result.square_23;
                    _grid[2][5] = result.square_24;
                    _grid[2][6] = result.square_25;
                    _grid[2][7] = result.square_26;
                    _grid[2][8] = result.square_27;
                    _grid[3][0] = result.square_28;
                    _grid[3][1] = result.square_29;
                    _grid[3][2] = result.square_30;
                    _grid[3][3] = result.square_31;
                    _grid[3][4] = result.square_32;
                    _grid[3][5] = result.square_33;
                    _grid[3][6] = result.square_34;
                    _grid[3][7] = result.square_35;
                    _grid[3][8] = result.square_36;
                    _grid[4][0] = result.square_37;
                    _grid[4][1] = result.square_38;
                    _grid[4][2] = result.square_39;
                    _grid[4][3] = result.square_40;
                    _grid[4][4] = result.square_41;
                    _grid[4][5] = result.square_42;
                    _grid[4][6] = result.square_43;
                    _grid[4][7] = result.square_44;
                    _grid[4][8] = result.square_45;
                    _grid[5][0] = result.square_46;
                    _grid[5][1] = result.square_47;
                    _grid[5][2] = result.square_48;
                    _grid[5][3] = result.square_49;
                    _grid[5][4] = result.square_50;
                    _grid[5][5] = result.square_51;
                    _grid[5][6] = result.square_52;
                    _grid[5][7] = result.square_53;
                    _grid[5][8] = result.square_54;
                    _grid[6][0] = result.square_55;
                    _grid[6][1] = result.square_56;
                    _grid[6][2] = result.square_57;
                    _grid[6][3] = result.square_58;
                    _grid[6][4] = result.square_59;
                    _grid[6][5] = result.square_60;
                    _grid[6][6] = result.square_61;
                    _grid[6][7] = result.square_62;
                    _grid[6][8] = result.square_63;
                    _grid[7][0] = result.square_64;
                    _grid[7][1] = result.square_65;
                    _grid[7][2] = result.square_66;
                    _grid[7][3] = result.square_67;
                    _grid[7][4] = result.square_68;
                    _grid[7][5] = result.square_69;
                    _grid[7][6] = result.square_70;
                    _grid[7][7] = result.square_71;
                    _grid[7][8] = result.square_72;
                    _grid[8][0] = result.square_73;
                    _grid[8][1] = result.square_74;
                    _grid[8][2] = result.square_75;
                    _grid[8][3] = result.square_76;
                    _grid[8][4] = result.square_77;
                    _grid[8][5] = result.square_78;
                    _grid[8][6] = result.square_79;
                    _grid[8][7] = result.square_80;
                    _grid[8][8] = result.square_81;
                }
                return _grid;
            }
            catch (Exception ex)
            {
                errorHandler(ex);
                _grid = new int[0][];
                return _grid;
            }
        }
    }
}
