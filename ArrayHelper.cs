using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_13
{
    
    public static class ArrayHelper<T>
    {
        ///<summary>
        ///Удаляет последний элемент массива и возвращает этот удалённый элемент.
        ///</summary>
        
        public static T Pop(ref T[] array)
        {
            if(array != null)
            {
                int endElement = array.Length - 1;
                T results = array[endElement];
                List<T> list = new List<T>();
                list.AddRange(array);
                list.RemoveAt(endElement);
                array = list.ToArray();
                return results;
            }
            else
                return default(T);
        }
        

        ///<summary>
        ///Добавляет элемент с конца массива и возвращает обновленную длину массива
        ///</summary>
        public static int Push(ref T[] array, T element)
        {
            if(array != null)
            {
                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = element;
            }
            return array.Length;
        }

        
        