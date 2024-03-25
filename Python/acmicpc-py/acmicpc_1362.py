# 1362 펫 

cnt = 0

while True:
    o, w = map(int, input().split())    

    if o == 0 and w == 0:
        break

    cnt = cnt + 1
    dead = False
    while True:
        a, b = input().split()
        
        if a == 'E': # 운동
            w = w - int(b)
            if w <= 0: # 사망
                dead = True

        elif a == 'F': #  먹이
            w = w + int(b)
        
        else: # a == '#' and b == '0'
            if dead:
                print(f"{cnt} :RIP")
            elif o / 2 < w < o * 2:
                print(f"{cnt} :-)") # 행복
            else:
                print(f"{cnt} :-(") # 슬픔
            break

    