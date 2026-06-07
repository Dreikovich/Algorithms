namespace algorithms.Arrays___Hashing;

public static class ValidSudoku {
    
    // 4 ms, beats 36.90% 
    //memory 48.88 beats 62.86%
    public static bool IsValidSudoku(char[][] board)
    {
        bool isRowCorrect = false;
        bool isSubBoxCorrect = false;
        bool isColumnCorrect = false;
        
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                if (i is 1 or 4 or 7 && j is 1 or 4 or 7)
                {
                    isSubBoxCorrect = CheckSubBox(board, i, j);
                    if (!isSubBoxCorrect)
                    {
                        return false;
                    }
                }
                if (i == j)
                {
                    isRowCorrect = CheckRow(board, i);
                    if (!isRowCorrect)
                    {
                        return false;
                    }

                    isColumnCorrect = CheckColumn(board, i);
                    if (!isColumnCorrect)
                    {
                        return false;
                    }
                }
            }
        }

        return true;
    }

    private static bool CheckColumn(char[][] board, int i)
    {
        var seen = new HashSet<char>();

        for (int n = 0; n < board[i].Length; n++)
        {
            char val = board[n][i];
            if(val == '.') continue;
            if (!seen.Add(val))
            {
                return false;
            }
        }

        return true;
    }

    private static bool CheckSubBox(char[][] board, int i, int j)
    {
        var seen = new HashSet<char>();
        for (int m = i - 1; m < i + 2; m++)
        {
            for (int n = j - 1; n < j + 2; n++)
            {
                var val = board[m][n];
                if(val == '.') continue;
                if (!seen.Add(val))
                {
                    return false;
                }
            }
        }

        return true;
    }


    private static bool CheckRow(char[][] board, int i)
    {
        var seen = new HashSet<char>();

        for (int n = 0; n < board[i].Length; n++)
        {
            char val = board[i][n];
            if(val == '.') continue;
            if (!seen.Add(val))
            {
                return false;
            }
        }

        return true;
    }
}