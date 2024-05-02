# 2588 곱셈

n1 = int(input())
n2 = int(input())
result = n1 * n2

while n2 > 0:
    k = n2 % 10
    n2 = n2 // 10
    print(n1 * k)

print(result)
