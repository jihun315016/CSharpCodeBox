# 5585 거스름돈

n = 1000 - int(input())
arr = [500, 100, 50, 10, 5, 1]
cnt = 0

for a in arr:
  cnt = cnt + (n // a)
  n = n % a

print(cnt)
