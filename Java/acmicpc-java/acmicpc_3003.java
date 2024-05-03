// 3003 킹, 퀸, 룩, 비숍, 나이트, 폰

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        List<Integer> chessList = new ArrayList<>(Arrays.asList(1, 1, 2, 2, 2, 8));    
        List<Integer> list = new ArrayList<>();

        for (int i = 0; i < 6; i++) {
            list.add(chessList.get(i) - sc.nextInt());
        }

        for(int item : list) {
            System.out.print(item + " ");
        }
    }
}
