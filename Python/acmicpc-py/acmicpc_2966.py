# 2966 찍기 

import math

n = int(input())
s = input()

p1 = "ABC"
p2 = "BABC"
p3 = "CCAABB"

p1 = p1 * math.ceil(n / len(p1))
p2 = p2 * math.ceil(n / len(p2))
p3 = p3 * math.ceil(n / len(p3))

scores = [[0, 1, "Adrian"], [0, 2, "Bruno"], [0, 3, "Goran"]]

for i in range(len(s)):
    if s[i] == p1[i]:
        scores[0][0] = scores[0][0] + 1

    if s[i] == p2[i]:
        scores[1][0] = scores[1][0] + 1

    if s[i] == p3[i]:
        scores[2][0] = scores[2][0] + 1

scores.sort(key=lambda x : (-x[0], x[1]))
print(scores[0][0])
for s in scores:
    if s[0] == scores[0][0]:
        print(s[2])
