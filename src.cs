class Solution {
    public List<int> solve(List<List<int>> A) {
        int N = A.Count();
        int M = A[0].Count();
        List<int> ColumnWiseSum = new List<int>();
        //Row Wise sum
        // for(int i = 0; i < N; i++){
        //     int sum  = 0;
        //     for(int j = 0; j < M; j++){
        //         sum = sum + A[i][j];
        //     }
        //     ColumnWiseSum.Add(sum);
        // }
        //Column wise sum
        for(int i = 0; i < M; i++){
            int sum  = 0;
            for(int j = 0; j < N; j++){
                sum = sum + A[j][i];
            }
            ColumnWiseSum.Add(sum);
        }
        return ColumnWiseSum;
    }
}
