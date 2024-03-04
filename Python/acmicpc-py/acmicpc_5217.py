# 5217 쌍의 합

def getPair(n):
    arr = []

    for i in range(1, n // 2 + 1):
        # 두 쌍은 다른 값이어야 함
        if i != n - i:
            arr.append('%d %d' % (i, n - i))

    return ', '.join(arr)

dic = {}
for i in range(1, 13):
    dic[i] = getPair(i)

t = int(input())
for _ in range(t):
    n = int(input())
    print('Pairs for %d:' %n, end=' ')
    print(dic[n])

