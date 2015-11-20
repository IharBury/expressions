using System;
using System.Linq.Expressions;
using Xunit;

namespace IharBury.Expressions.Tests
{
    public class EvaluateTests
    {
        [Fact]
        public void Evaluate0ArgumentsTest()
        {
            Expression<Func<int>> f1 = () => 5;

            Assert.Equal(5, f1.Evaluate());
        }

        [Fact]
        public void Evaluate1ArgumentsTest()
        {
            Expression<Func<int, int>> f1 = x => x + 1;

            Assert.Equal(6, f1.Evaluate(5));
        }

        [Fact]
        public void Evaluate2ArgumentsTest()
        {
            Expression<Func<int, int, int>> f1 = (x1, x2) => x1 + x2 * 2;

            Assert.Equal(5, f1.Evaluate(1, 2));
        }

        [Fact]
        public void Evaluate3ArgumentsTest()
        {
            Expression<Func<int, int, int, int>> f1 = (x1, x2, x3) => x1 + x2 * 2 + x3 * 3;

            Assert.Equal(14, f1.Evaluate(1, 2, 3));
        }

        [Fact]
        public void Evaluate4ArgumentsTest()
        {
            Expression<Func<int, int, int, int, int>> f1 = (x1, x2, x3, x4) => x1 + x2 * 2 + x3 * 3 + x4 * 4;

            Assert.Equal(30, f1.Evaluate(1, 2, 3, 4));
        }

#if !NET35 && !NET35_CLIENT
        [Fact]
        public void Evaluate5ArgumentsTest()
        {
            Expression<Func<int, int, int, int, int, int>> f1 = (x1, x2, x3, x4, x5) => x1 + x2 * 2 + x3 * 3 + x4 * 4 + x5;

            Assert.Equal(35, f1.Evaluate(1, 2, 3, 4, 5));
        }

        [Fact]
        public void Evaluate6ArgumentsTest()
        {
            Expression<Func<int, int, int, int, int, int, int>> f1 =
                (x1, x2, x3, x4, x5, x6) => x1 + x2 * 2 + x3 * 3 + x4 * 4 + x5 + x6;

            Assert.Equal(41, f1.Evaluate(1, 2, 3, 4, 5, 6));
        }

        [Fact]
        public void Evaluate7ArgumentsTest()
        {
            Expression<Func<int, int, int, int, int, int, int, int>> f1 =
                (x1, x2, x3, x4, x5, x6, x7) => x1 + x2 * 2 + x3 * 3 + x4 * 4 + x5 + x6 + x7;

            Assert.Equal(48, f1.Evaluate(1, 2, 3, 4, 5, 6, 7));
        }

        [Fact]
        public void Evaluate8ArgumentsTest()
        {
            Expression<Func<int, int, int, int, int, int, int, int, int>> f1 =
                (x1, x2, x3, x4, x5, x6, x7, x8) => x1 + x2 * 2 + x3 * 3 + x4 * 4 + x5 + x6 + x7 + x8;

            Assert.Equal(56, f1.Evaluate(1, 2, 3, 4, 5, 6, 7, 8));
        }

        [Fact]
        public void Evaluate9ArgumentsTest()
        {
            Expression<Func<int, int, int, int, int, int, int, int, int, int>> f1 =
                (x1, x2, x3, x4, x5, x6, x7, x8, x9) => x1 + x2 * 2 + x3 * 3 + x4 * 4 + x5 + x6 + x7 + x8 + x9;

            Assert.Equal(65, f1.Evaluate(1, 2, 3, 4, 5, 6, 7, 8, 9));
        }

        [Fact]
        public void Evaluate10ArgumentsTest()
        {
            Expression<Func<int, int, int, int, int, int, int, int, int, int, int>> f1 =
                (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10) => x1 + x2 * 2 + x3 * 3 + x4 * 4 + x5 + x6 + x7 + x8 + x9 + x10;

            Assert.Equal(75, f1.Evaluate(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
        }

        [Fact]
        public void Evaluate11ArgumentsTest()
        {
            Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int>> f1 =
                (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11) =>
                    x1 + x2 * 2 + x3 * 3 + x4 * 4 + x5 + x6 + x7 + x8 + x9 + x10 + x11;

            Assert.Equal(86, f1.Evaluate(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11));
        }

        [Fact]
        public void Evaluate12ArgumentsTest()
        {
            Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int>> f1 =
                (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12) =>
                    x1 + x2 * 2 + x3 * 3 + x4 * 4 + x5 + x6 + x7 + x8 + x9 + x10 + x11 + x12;

            Assert.Equal(98, f1.Evaluate(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12));
        }

        [Fact]
        public void Evaluate13ArgumentsTest()
        {
            Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int>> f1 =
                (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13) =>
                    x1 + x2 * 2 + x3 * 3 + x4 * 4 + x5 + x6 + x7 + x8 + x9 + x10 + x11 + x12 - x13;

            Assert.Equal(85, f1.Evaluate(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13));
        }

        [Fact]
        public void Evaluate14ArgumentsTest()
        {
            Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>> f1 =
                (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14) =>
                    x1 + x2 * 2 + x3 * 3 + x4 * 4 + x5 + x6 + x7 + x8 + x9 + x10 + x11 + x12 - x13 - x14;

            Assert.Equal(71, f1.Evaluate(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14));
        }

        [Fact]
        public void Evaluate15ArgumentsTest()
        {
            Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>> f1 =
                (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15) =>
                    x1 + x2 * 2 + x3 * 3 + x4 * 4 + x5 + x6 + x7 + x8 + x9 + x10 + x11 + x12 - x13 - x14 - x15;

            Assert.Equal(56, f1.Evaluate(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15));
        }

        [Fact]
        public void Evaluate16ArgumentsTest()
        {
            Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>> f1 =
                (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16) =>
                    x1 + x2 * 2 + x3 * 3 + x4 * 4 + x5 + x6 + x7 + x8 + x9 + x10 + x11 + x12 - x13 - x14 - x15 - x16;

            Assert.Equal(40, f1.Evaluate(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16));
        }
#endif
    }
}
