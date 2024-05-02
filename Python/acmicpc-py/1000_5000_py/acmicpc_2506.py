# 2506 점수계산

n = int(input())
arr = list(map(int, input().split()))

cur = 1
total = 0
for a in arr:
    if a == 1:
        total = total + cur
        cur = cur + 1
    else:
        cur = 1

print(total)
