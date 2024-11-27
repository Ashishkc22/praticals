#include <stdio.h>
#define INT_MAX 999
#define MAX 100

void Prim(int n, int cost[MAX][MAX], int t[MAX][2]) {
    int near[MAX], mincost = 0;
    int k = 0, L = 0,i,j,y;
	for (y=0;y<n;y++)
    {
    	near[y]=INT_MAX;
//    	printf(" %d ",near[y]);
	}
    int min = INT_MAX;
    for (i = 0; i < n; i++) {
        for (j = 0; j < n; j++) {
            if (cost[i][j] < min && cost[i][j] != 0) {
                min = cost[i][j];
                k = i;
                L = j;
            }
        }
    }
    mincost = cost[k][L];
    t[0][0] = k;
    t[0][1] = L;
	// printf("K : %d \nL : %d \nminimum cost : %d\nT : %d -> %d",k,L,mincost,t[0][0],t[0][1]);
	for (i = 0; i < n; i++) {
		// printf("i: %d cost[%d][%d] : %d , cost[%d][%d] : %d",i,i,k,cost[i][k],i,L,cost[i][L]);
        if (cost[i][L] < cost[i][k]) {
            near[i] = L;
        } else if (cost[i][L]!=999){
            near[i] = k;
        }
    }
	near[k] = near[L] = -1;
//	for (y=0;y<n;y++)
//    {
//    	printf("\n %d - %d ",y,near[y]);
//	}
//	for (y=0;y<n;y++)
//		printf(" %d ",near[y]);

    int m;
	j=0;
    for (i = 1; i < n ; i++) {
    	int min = 9999;
        for (m = 0; m < n; m++) {
            if (cost[m][near[m]] < min && near[m]!=-1 && near[m]!=999) {
                min = cost[m][near[m]];  
                j = m;
                // printf("\n j :  %d",j);
            }
        }
        t[i][0] = j;
        t[i][1] = near[j];
        // printf("selected edge - %d %d ",t[i][0],t[i][1]);
        mincost += cost[j][near[j]];
        near[j] = -1;

        for (k = 0; k < n; k++) {
            if (near[k] != -1 && cost[k][j] < cost[k][near[k]] && cost[k][near[k]]!=999) {
                near[k] = j;
            }
        }
        for (y=0;y<n;y++)
			printf("near = %d ",near[y]);
		printf("\n");
//        for (y=0;y<n;y++)
//		printf(" %d \t",near[y]);
//		printf("\n");
    }

//    printf("Minimum cost: %d\n", mincost);
//    printf("The edges in the MST are:\n");
//    for (i = 0; i < n - 1; i++) {
//        printf("(%d, %d)\n", t[i][0], t[i][1]);
//    }
}

int main() {
    int n,i,j;
    int cost[MAX][MAX];
    int t[MAX][2];

    printf("\n Enter the Number of Vertices: ");
    scanf("%d", &n);

    printf("\n Enter the Adjacency Matrix\n");
    for (i = 0; i < n; i++) {
        for (j = 0; j < n; j++) {
            scanf("%d", &cost[i][j]);
        }
    }
    for (i = 0; i < n; i++) {
        for (j = 0; j < n; j++) {
            if (cost[i][j]==0){
            	cost[i][j]=999;
			}
        }
    }
    printf("\n Adjacency Matrix\n");
	for (i = 0; i < n; i++) {
	    for (j = 0; j < n; j++) {
	    	printf("%d ",cost[i][j]);
	    }
	    printf("\n");
	}
    Prim(n, cost, t);
    return 0;
}
