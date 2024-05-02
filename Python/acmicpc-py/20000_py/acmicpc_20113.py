# 20113 긴급 회의

import sys
input = sys.stdin.readline

n = int(input())
arr = list(map(int, input().split()))
voteArr = [0] * (n + 1)

for a in arr:
  if a != 0:
    voteArr[a] = voteArr[a] + 1

maxVote = max(voteArr)
if voteArr.count(maxVote) > 1:
  print("skipped")
else:
  idx = voteArr.index(maxVote)
  print(idx)
