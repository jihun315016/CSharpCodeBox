# 1284 집 주소

while True:
    n = int(input())
    if n == 0:
        break

    w = 0
    while n > 0:
        k = n % 10
        n = n // 10

        if k == 0:
            w = w + 4
        elif k == 1:
            w = w + 2
        else:
            w = w + 3

        w = w + 1 # 자릿수 하나당 1칸 추가
    
    # 호수판의 양쪽 경계 -> 2칸 추가해야하지만
    # 숫자간 공백은 자릿수 - 1이 되어야하므로 1만 더함
    print(w + 1)
