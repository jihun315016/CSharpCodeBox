# 1075 나누기

n = int(input())
f = int(input())

# 뒤에 두 자리를 00으로 만들기
dNum = (n // 100) * 100

# 몫
k = dNum // f

if dNum % f == 0:
    m = f * k
    print('%02d' % (m % 100))
else:
    m = f * (k + 1)
    print('%02d' % (m % 100))
