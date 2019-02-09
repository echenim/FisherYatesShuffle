# Fisher–Yates shuffle-algorithms

#The Fisher–Yates shuffle is an algorithm for generating a random permutation of a finite sequence—in plain terms, 
the algorithm shuffles the sequence. The algorithm effectively puts all the elements into a hat; it continually 
determines the next element by randomly drawing an element from the hat until no elements remain. The algorithm 
produces an unbiased permutation: every permutation is equally likely. The modern version of the algorithm is efficient: 
it takes time proportional to the number of items being shuffled and shuffles them in place.

# To initialize an array a of n elements to a randomly shuffled copy of source, both 0-based:
#  for i from 0 to n − 1 do
#      j ← random integer such that 0 ≤ j ≤ i
#      if j ≠ i
#          a[i] ← a[j]
#      a[j] ← source[i]
