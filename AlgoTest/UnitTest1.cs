using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Algorithms;
using System.Reflection;

namespace AlgoTest
{
    [TestClass]
    public class UnitTest1
    {
        private int _valueToSearch = 10;

        [TestMethod]
        public void There_An_Index_In_Array_AntiCurseLineSearch()
        {
            //arrange
            int[] array = { -3, 0, 1, 3, 4, 5, 7, 8, 12 };
            int index = 4;
            var value = 4;

            //act
            int returned_index = Algorithm.AntiCurseLineSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void There_An_Index_In_Array_CurseBinarySearch()
        {
            //arrange
            int[] array = { -3, 0, 1, 3, 4, 5, 7, 8, 12 };
            int index = 4;
            var value = 4;

            //act
            int returned_index = Algorithm.CurseBinarySearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void There_An_Index_In_Array_InterpolationSearch()
        {
            //arrange
            int[] array = { -3, 0, 1, 3, 4, 5, 7, 8, 12 };

            int index = 4;
            var value = 4;

            //act
            int returned_index = Algorithm.InterpolationSearch(array, value);           

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void There_An_Index_In_Array_CurseJumpSearch()
        {
            //arrange
            int[] array = { -3, 0, 1, 3, 4, 5, 7, 8, 12 };
            int index = 4;
            var value = 4;

            //act
            int returned_index = Algorithm.CurseJumpSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void First_Index_In_Array_AntiCurseLineSearchh()
        {
            //arrange
            int[] array = { -2, -1, -1, 3, 4, 5, 7, 8, 12 };
            int index = 1;
            var value = -1;

            //act
            int returned_index = Algorithm.AntiCurseLineSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void First_Index_In_Array_CurseBinarySearch()
        {
            //arrange
            int[] array = { -2, -1, -1, 3, 4, 5, 7, 8, 12 };
            int index = 1;
            var value = -1;

            //act
            int returned_index = Algorithm.CurseBinarySearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void First_Index_In_Array_InterpolationSearch()
        {
            //arrange
            int[] array = { -1, -1, -1, -1, -1, -1, -1, -1, -1 };
            int index = 0;
            var value = -1;

            //act
            int returned_index = Algorithm.InterpolationSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void First_Index_In_Array_CurseJumpSearch()
        {
            //arrange
            int[] array = { -2, -1, -1, 3, 4, 5, 7, 8, 12 };
            int index = 1;
            var value = -1;

            //act
            int returned_index = Algorithm.CurseJumpSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void First_Index_In_Array_AntiCurseFastLineSearch()
        {
            //arrange
            int[] array = { -2, -1, -1, 3, 4, 5, 7, 8, 12 };
            int index = 1;
            var value = -1;

            //act
            int returned_index = Algorithm.AntiCurseFastLineSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void Last_Index_In_Array_AntiCurseLineSearch()
        {
            //arrange
            int[] array = { -3, 0, 1, 3, 4, 5, 7, 8, 12 };
            int index = array.Length - 1;
            var value = 12;

            //act
            int returned_index = Algorithm.AntiCurseLineSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void Last_Index_In_Array_CurseBinarySearch()
        {
            //arrange
            int[] array = { -3, 0, 1, 3, 4, 5, 7, 8, 12 };
            int index = array.Length - 1;
            var value = 12;

            //act
            int returned_index = Algorithm.CurseBinarySearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void Last_Index_In_Array_InterpolationSearch()
        {
            //arrange
            int[] array = { -3, 0, 1, 3, 4, 5, 7, 8, 12 };
            int index = array.Length - 1;
            var value = 12;

            //act
            int returned_index = Algorithm.InterpolationSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void Last_Index_In_Array_CurseJumpSearch()
        {
            //arrange
            int[] array = { -3, 0, 1, 3, 4, 5, 7, 8, 12 };
            int index = array.Length - 1;
            var value = 12;

            //act
            int returned_index = Algorithm.CurseJumpSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void Last_Index_In_Array_AntiCurseFastLineSearch()
        {
            //arrange
            int[] array = { -3, 0, 1, 3, 4, 5, 7, 8, 12 };
            int index = array.Length - 1;
            var value = 12;

            //act
            int returned_index = Algorithm.AntiCurseFastLineSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void There_Is_No_Index_In_Array_AntiCurseLineSearch()
        {
            //arange
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int index = -1;
            var value = 11;

            //act
            int returned_index = Algorithm.AntiCurseLineSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void There_Is_No_Index_In_Array_CurseBinarySearch()
        {
            //arange
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int index = -1;
            var value = 11;

            //act
            int returned_index = Algorithm.CurseBinarySearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void There_Is_No_Index_In_Array_InterpolationSearch()
        {
            //arange
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int index = -1;
            var value = 11;

            //act
            int returned_index = Algorithm.InterpolationSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void There_Is_No_Index_In_Array_CurseJumpSearch()
        {
            //arange
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int index = -1;
            var value = 11;

            //act
            int returned_index = Algorithm.CurseJumpSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }
    }
}
