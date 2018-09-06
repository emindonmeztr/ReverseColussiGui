# ReverseColussiGui
# C# form application about Reverse Colussi string matching algorithm.
# Main features
refinement of the Boyer-Moore algorithm

partitions the set of pattern positions into two disjoint subsets

preprocessing phase in O(m2) time and O(msigma) space

searching phase in O(n) time complexity;

2n text character comparisons in the worst case.

The character comparisons are done using a specific order given by a table h.

# Description
For each integer i such that 0 leq i leq m we define two disjoint sets:
 	Pos(i)={k :  0 leq k leq i and x[i] = x[i-k]}
 	Neg(i)={k :  0 leq k leq i and x[i] neq x[i-k]}
For 1 leq k leq m, let hmin[k] be the minimum integer ell such that ell geq k-1 and k not in Neg(i) for all i such that ell < i leq m-1.

For 0 leq ell leq m-1, let kmin[ell] be the minimum integer k such that hmin[k]=ell geq k if any such k exists and kmin[ell]=0 otherwise.

For 0 leq ell leq m-1, let rmin[ell] be the minimum integer k such that r > ell and hmin[r]=r-1.

The value of h[0] is set to m-1. After that we choose in increasing order of kmin[ell], all the indexes h[1], ... , h[d] such that kmin[h[i]] neq 0 and we set rcGs[i] to kmin[h[i]] for 1 leq i leq d. Then we choose the indexes h[d+1], ... , h[m-1] in increasing order and we set rcGs[i] to rmin[h[i]] for d < i < m.

The value of rcGs[m] is set to the period of x.

The table rcBc is defined as follows: rcBc[a, s]=min{k :  (k=m or x[m-k-1]=a) and (k > m-s-1 or x[m-k-s-1]=x[m-s-1])} To compute the table rcBc we define: for each c in Sigma, locc[c] is the index of the rightmost occurrence of c in x[0 .. m-2] (locc[c] is set to -1 if c does not occur in x[0 .. m-2]).

A table link is used to link downward all the occurrences of each pattern character.

The preprocessing phase can be performed in O(m2) time and O(msigma) space complexity. The searching phase is in O(n) time complexity.


Thanks for all works and contributions to my friend -#Sinan Çürük.
