class Solution {
public:
    vector<int> sortedSquares(vector<int>& A) {
        vector<int> res(A.size());
        int n = A.size();
        for(int i = 0; i < n; i++) {
            res[i] = A[i] * A[i];
        }
        sort(res.begin(), res.end());
        return res;
    }
};