# 1357 뒤집힌 덧셈

def rev(x):
    return int(str(x)[::-1])

a, b = map(int, input().split())
k = rev(a) + rev(b)
k = rev(k)
print(k)
