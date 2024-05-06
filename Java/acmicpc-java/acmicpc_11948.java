// 11948 과목선택

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        List<Integer> scores = new ArrayList<>();
        int a, b; // 합계 2개
        List<Integer> temp; // 합계를 구할 리스트(과목별로 두 분류로 나누어야 함)

        for (int i = 0; i < 6; i++) {
            scores.add(sc.nextInt());
        }

        temp = scores.stream().limit(4).collect(Collectors.toList());
        Collections.sort(temp);
        a = temp.stream().mapToInt(Integer::intValue).sum() - temp.get(0);

        temp = scores.stream().skip(4).limit(2).collect(Collectors.toList());
        Collections.sort(temp);
        b = temp.stream().mapToInt(Integer::intValue).sum() - temp.get(0);

        System.out.println(a + b);
    }
}
