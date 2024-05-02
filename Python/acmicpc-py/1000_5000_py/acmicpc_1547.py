# 1547 공

m = int(input())
cur = 1

for _ in range(m):
    a, b = map(int, input().split())

    if cur == a:
        cur = b
    elif cur == b:
        cur = a

print(cur)