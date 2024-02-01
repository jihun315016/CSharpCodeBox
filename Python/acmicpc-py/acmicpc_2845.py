# 2845 파티가 끝나고 난 뒤

a, b = map(int, input().split())
c = a * b

arr = list(map(int, input().split()))
for i in arr:
    print(i - c, end=' ')