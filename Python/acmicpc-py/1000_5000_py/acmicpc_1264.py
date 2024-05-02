# 1264 모음의 개수

while True:
    s = input()
    c = 0

    if s == '#':
        break

    for a in ['a', 'e', 'i', 'o', 'u']:
        c = c + s.lower().count(a)
    
    print(c)
    