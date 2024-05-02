# 2446 별 찍기 - 9

n = int(input())
star = n * 2 - 1

for i in range(n):
    print(' ' * i, end='')
    print('*' * star)
    star = star - 2

star = 3
for i in range(n - 1):
    print(' ' * (n - 2 - i), end='')
    print('*' * star)
    star = star + 2
