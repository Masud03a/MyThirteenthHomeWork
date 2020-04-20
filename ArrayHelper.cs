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

        