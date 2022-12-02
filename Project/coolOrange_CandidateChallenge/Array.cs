using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coolOrange_CandidateChallenge
{
    public class Array
    {

//*********************Idiot Task************************        
        public static void controlling(ref position1, ref position2)
        {
            int help =position1;
            if(position1>position2)
            {
                position1=position2;
                position2=help;
            }
        }
//*********************Task 1************************
        public static int FindMaxValue(int[] array, int position1, int position2)
        {
            controlling(ref Position1,ref position1);
            int max=array[position1];
            for(int i=position1; i<position2+1; i++){
                if(max<array[i])
                    max=array[i];
            }
            return max;
        } 

//*********************Task 2************************
        public static int FindMinPosition(int[] array, int position1, int position2)
        {
            controlling(ref Position1,ref position1);
            int max=array[position1];
            int j=0;
            for(int i=position1; i<position2+1; i++){
                if(max>array[i]){
                    max=array[i];
                    j=i;
                }
            }
            return j;
        }
//*********************Task 3************************
        public static int[] Swap(int[] array, int position1, int position2)
        {
            int swap=array[position1];
            array[position1]=array[position2];
            array[position2]=swap;
            return array;
        }
//*********************Task 4************************
        public static int[] ShiftLeftByOne(int[] array, int position1, int position2)
        {
            controlling(ref position1, ref position2);
            for(int i=position1;i<position2;i++)
            {
                array[i]=array[i+1];
            }
        return array;
        }
//*********************Task 5************************
        public static int[] CreateRandomArray(int size, int minValue, int maxValue)
        {
            controlling(ref minValue, ref maxValue);
            int[] array =new int[size];
            var r=new Random();
            for(int i=0;i<size;i++)
            {
                array[i]=r.Next(minValue,maxValue+1);
            }
            return array;
        }
//*********************Task 6************************
        public static int[,] CreateRandomMatrix(int rows, int columns, int minValue, int maxValue)
        {
            controlling(ref minValue, ref maxValue);
            int[,] array =new int[rows,columns];
            var r=new Random();
            for(int i=0;i<rows;i++)
            {
                for(int j=0;j<columns;j++){
                    array[i,j]=r.Next(minValue,maxValue+1);
                }
            }
            return array;
        }
//*********************Task 7************************
        public static int[,] CopyArray(int[] array)
        {
            int[,] array1=new int[2,array.Length];
            for(int i=0;i<array.Length;i++)
            {
                array1[0,i]=array[i];
                array1[1,i]=array[i];
            }
            return array1;
        } 
//*********************Task 8************************     
        public static int FindInSortedArrary(int[] array, int number){
            int min = 0;
            int max = array.Length - 1;
            while(min<=max)
            {
                int mid = (min + max)/2;
                if(number == array[mid])
                {
                    return ++mid;
                }
                else if(number<array[mid])
                {   
                    max=mid-1;
                }
                else
                {
                    min=mid+1;
                }
            }
            return 0;
        }


    }
    
}
