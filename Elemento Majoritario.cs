//
Dado um array nums de tamanho n, retorne o elemento majoritário, isto é, o elemento que aparece o maior número de vezes no seu array.
//

using System;
using System.Text.RegularExpressions;

public class Program{
    public static void Main(String[] args){
        int n = int.Parse(Console.ReadLine());
        int[] num = new int[n];
        for (int i = 0; i < num.Length; i++){
            num[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(MajorityElement(num));
    }
    public static int MajorityElement(int[] nums){
        int major = nums[0];
        int count = 1;
        int majorCount = 1;
        for (int i = 0; i < nums.Length; i++){
            for (int j = 0; j < nums.Length; j++){ 
                if (nums[j] == nums[i]){
                    if (count >= majorCount){
                        major = nums[i];
                        count = 0;
                    }
                    count++;
                }
            }
        }
        return major;
    }
}
