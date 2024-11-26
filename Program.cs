//*****************************************************************************
//** 2924. Find Champion II      leetcode                                    **
//*****************************************************************************

int findChampion(int n, int** edges, int edgesSize, int* edgesColSize) {
    int indeg[n];
    memset(indeg, 0, sizeof(indeg));

    for(int i = 0; i < edgesSize; i++)
    {
        indeg[edges[i][1]]++;
    }

    int ans = -1;
    int count = 0;

    for(int i = 0; i < n; i++)
    {
        if (indeg[i] == 0)
        {
            count++;
            ans = i;
        }
    }

    return (count == 1) ? ans : -1;
}