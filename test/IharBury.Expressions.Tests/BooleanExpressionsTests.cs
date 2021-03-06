﻿using System;
using System.Linq.Expressions;
using Xunit;

namespace IharBury.Expressions.Tests
{
    public class BooleanExpressionsTests
    {
        [Fact]
        public void AndAlso0ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<bool>> expression1 = () => value1;
                    var result = expression1.AndAlso(() => value2);
                    Assert.Equal(value1 && value2, result.Compile().Invoke());
                }
            }
        }

        [Fact]
        public void AndAlso1ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<int, bool>> expression1 = x1 => value1;
                    var result = expression1.AndAlso(x1 => value2);
                    Assert.Equal(value1 && value2, result.Compile().Invoke(1));
                }
            }
        }

        [Fact]
        public void AndAlso2ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<int, int, bool>> expression1 = (x1, x2) => value1;
                    var result = expression1.AndAlso((x1, x2) => value2);
                    Assert.Equal(value1 && value2, result.Compile().Invoke(1, 2));
                }
            }
        }

        [Fact]
        public void AndAlso3ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<int, int, int, bool>> expression1 = (x1, x2, x3) => value1;
                    var result = expression1.AndAlso((x1, x2, x3) => value2);
                    Assert.Equal(value1 && value2, result.Compile().Invoke(1, 2, 3));
                }
            }
        }

        [Fact]
        public void AndAlso4ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<int, int, int, int, bool>> expression1 = (x1, x2, x3, x4) => value1;
                    var result = expression1.AndAlso((x1, x2, x3, x4) => value2);
                    Assert.Equal(value1 && value2, result.Compile().Invoke(1, 2, 3, 4));
                }
            }
        }

        [Fact]
        public void AndAlso5ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<int, int, int, int, int, bool>> expression1 = (x1, x2, x3, x4, x5) => value1;
                    var result = expression1.AndAlso((x1, x2, x3, x4, x5) => value2);
                    Assert.Equal(value1 && value2, result.Compile().Invoke(1, 2, 3, 4, 5));
                }
            }
        }

        [Fact]
        public void AndAlso6ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<int, int, int, int, int, int, bool>> expression1 = (x1, x2, x3, x4, x5, x6) => value1;
                    var result = expression1.AndAlso((x1, x2, x3, x4, x5, x6) => value2);
                    Assert.Equal(value1 && value2, result.Compile().Invoke(1, 2, 3, 4, 5, 6));
                }
            }
        }

        [Fact]
        public void AndAlso7ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<int, int, int, int, int, int, int, bool>> expression1 =
                        (x1, x2, x3, x4, x5, x6, x7) => value1;
                    var result = expression1.AndAlso((x1, x2, x3, x4, x5, x6, x7) => value2);
                    Assert.Equal(value1 && value2, result.Compile().Invoke(1, 2, 3, 4, 5, 6, 7));
                }
            }
        }

        [Fact]
        public void AndAlso8ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<int, int, int, int, int, int, int, int, bool>> expression1 =
                        (x1, x2, x3, x4, x5, x6, x7, x8) => value1;
                    var result = expression1.AndAlso((x1, x2, x3, x4, x5, x6, x7, x8) => value2);
                    Assert.Equal(value1 && value2, result.Compile().Invoke(1, 2, 3, 4, 5, 6, 7, 8));
                }
            }
        }

        [Fact]
        public void AndAlso9ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<int, int, int, int, int, int, int, int, int, bool>> expression1 =
                        (x1, x2, x3, x4, x5, x6, x7, x8, x9) => value1;
                    var result = expression1.AndAlso((x1, x2, x3, x4, x5, x6, x7, x8, x9) => value2);
                    Assert.Equal(value1 && value2, result.Compile().Invoke(1, 2, 3, 4, 5, 6, 7, 8, 9));
                }
            }
        }

        [Fact]
        public void AndAlso10ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<int, int, int, int, int, int, int, int, int, int, bool>> expression1 =
                        (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10) => value1;
                    var result = expression1.AndAlso((x1, x2, x3, x4, x5, x6, x7, x8, x9, x10) => value2);
                    Assert.Equal(value1 && value2, result.Compile().Invoke(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
                }
            }
        }

        [Fact]
        public void AndAlso11ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<int, int, int, int, int, int, int, int, int, int, int, bool>> expression1 =
                        (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11) => value1;
                    var result = expression1.AndAlso((x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11) => value2);
                    Assert.Equal(value1 && value2, result.Compile().Invoke(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11));
                }
            }
        }

        [Fact]
        public void AndAlso12ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, bool>> expression1 =
                        (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12) => value1;
                    var result = expression1.AndAlso((x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12) => value2);
                    Assert.Equal(value1 && value2, result.Compile().Invoke(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12));
                }
            }
        }

        [Fact]
        public void AndAlso13ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, bool>> expression1 =
                        (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13) => value1;
                    var result = expression1.AndAlso((x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13) => value2);
                    Assert.Equal(value1 && value2, result.Compile().Invoke(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13));
                }
            }
        }

        [Fact]
        public void AndAlso14ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, bool>> expression1 =
                        (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14) => value1;
                    var result = expression1.AndAlso((x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14) => value2);
                    Assert.Equal(value1 && value2, result.Compile().Invoke(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14));
                }
            }
        }

        [Fact]
        public void AndAlso15ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, bool>>
                        expression1 = (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15) => value1;
                    var result = expression1.AndAlso(
                        (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15) => value2);
                    Assert.Equal(value1 && value2, result.Compile().Invoke(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15));
                }
            }
        }

        [Fact]
        public void AndAlso16ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, bool>>
                        expression1 = (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16) => value1;
                    var result = expression1.AndAlso(
                        (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16) => value2);
                    Assert.Equal(value1 && value2, result.Compile().Invoke(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16));
                }
            }
        }

        [Fact]
        public void AndAlso2ParameterReplacementTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<bool, bool, bool>> expression1 = (x1, x2) => x1;
                    var result = expression1.AndAlso((x1, x2) => x2);
                    Assert.Equal(value1 && value2, result.Compile().Invoke(value1, value2));
                }
            }
        }

        [Fact]
        public void OrElse0ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<bool>> expression1 = () => value1;
                    var result = expression1.OrElse(() => value2);
                    Assert.Equal(value1 || value2, result.Compile().Invoke());
                }
            }
        }

        [Fact]
        public void OrElse1ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<int, bool>> expression1 = x1 => value1;
                    var result = expression1.OrElse(x1 => value2);
                    Assert.Equal(value1 || value2, result.Compile().Invoke(1));
                }
            }
        }

        [Fact]
        public void OrElse2ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<int, int, bool>> expression1 = (x1, x2) => value1;
                    var result = expression1.OrElse((x1, x2) => value2);
                    Assert.Equal(value1 || value2, result.Compile().Invoke(1, 2));
                }
            }
        }

        [Fact]
        public void OrElse3ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<int, int, int, bool>> expression1 = (x1, x2, x3) => value1;
                    var result = expression1.OrElse((x1, x2, x3) => value2);
                    Assert.Equal(value1 || value2, result.Compile().Invoke(1, 2, 3));
                }
            }
        }

        [Fact]
        public void OrElse4ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<int, int, int, int, bool>> expression1 = (x1, x2, x3, x4) => value1;
                    var result = expression1.OrElse((x1, x2, x3, x4) => value2);
                    Assert.Equal(value1 || value2, result.Compile().Invoke(1, 2, 3, 4));
                }
            }
        }

        [Fact]
        public void OrElse5ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<int, int, int, int, int, bool>> expression1 = (x1, x2, x3, x4, x5) => value1;
                    var result = expression1.OrElse((x1, x2, x3, x4, x5) => value2);
                    Assert.Equal(value1 || value2, result.Compile().Invoke(1, 2, 3, 4, 5));
                }
            }
        }

        [Fact]
        public void OrElse6ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<int, int, int, int, int, int, bool>> expression1 = (x1, x2, x3, x4, x5, x6) => value1;
                    var result = expression1.OrElse((x1, x2, x3, x4, x5, x6) => value2);
                    Assert.Equal(value1 || value2, result.Compile().Invoke(1, 2, 3, 4, 5, 6));
                }
            }
        }

        [Fact]
        public void OrElse7ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<int, int, int, int, int, int, int, bool>> expression1 =
                        (x1, x2, x3, x4, x5, x6, x7) => value1;
                    var result = expression1.OrElse((x1, x2, x3, x4, x5, x6, x7) => value2);
                    Assert.Equal(value1 || value2, result.Compile().Invoke(1, 2, 3, 4, 5, 6, 7));
                }
            }
        }

        [Fact]
        public void OrElse8ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<int, int, int, int, int, int, int, int, bool>> expression1 =
                        (x1, x2, x3, x4, x5, x6, x7, x8) => value1;
                    var result = expression1.OrElse((x1, x2, x3, x4, x5, x6, x7, x8) => value2);
                    Assert.Equal(value1 || value2, result.Compile().Invoke(1, 2, 3, 4, 5, 6, 7, 8));
                }
            }
        }

        [Fact]
        public void OrElse9ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<int, int, int, int, int, int, int, int, int, bool>> expression1 =
                        (x1, x2, x3, x4, x5, x6, x7, x8, x9) => value1;
                    var result = expression1.OrElse((x1, x2, x3, x4, x5, x6, x7, x8, x9) => value2);
                    Assert.Equal(value1 || value2, result.Compile().Invoke(1, 2, 3, 4, 5, 6, 7, 8, 9));
                }
            }
        }

        [Fact]
        public void OrElse10ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<int, int, int, int, int, int, int, int, int, int, bool>> expression1 =
                        (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10) => value1;
                    var result = expression1.OrElse((x1, x2, x3, x4, x5, x6, x7, x8, x9, x10) => value2);
                    Assert.Equal(value1 || value2, result.Compile().Invoke(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
                }
            }
        }

        [Fact]
        public void OrElse11ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<int, int, int, int, int, int, int, int, int, int, int, bool>> expression1 =
                        (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11) => value1;
                    var result = expression1.OrElse((x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11) => value2);
                    Assert.Equal(value1 || value2, result.Compile().Invoke(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11));
                }
            }
        }

        [Fact]
        public void OrElse12ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, bool>> expression1 =
                        (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12) => value1;
                    var result = expression1.OrElse((x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12) => value2);
                    Assert.Equal(value1 || value2, result.Compile().Invoke(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12));
                }
            }
        }

        [Fact]
        public void OrElse13ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, bool>> expression1 =
                        (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13) => value1;
                    var result = expression1.OrElse((x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13) => value2);
                    Assert.Equal(value1 || value2, result.Compile().Invoke(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13));
                }
            }
        }

        [Fact]
        public void OrElse14ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, bool>> expression1 =
                        (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14) => value1;
                    var result = expression1.OrElse((x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14) => value2);
                    Assert.Equal(value1 || value2, result.Compile().Invoke(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14));
                }
            }
        }

        [Fact]
        public void OrElse15ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, bool>>
                        expression1 = (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15) => value1;
                    var result = expression1.OrElse(
                        (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15) => value2);
                    Assert.Equal(value1 || value2, result.Compile().Invoke(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15));
                }
            }
        }

        [Fact]
        public void OrElse16ParameterTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, bool>>
                        expression1 = (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16) => value1;
                    var result = expression1.OrElse(
                        (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16) => value2);
                    Assert.Equal(value1 || value2, result.Compile().Invoke(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16));
                }
            }
        }

        [Fact]
        public void OrElse2ParameterReplacementTest()
        {
            foreach (var value1 in new[]
            {
                false,
                true
            })
            {
                foreach (var value2 in new[]
                {
                    false,
                    true
                })
                {
                    Expression<Func<bool, bool, bool>> expression1 = (x1, x2) => x1;
                    var result = expression1.OrElse((x1, x2) => x2);
                    Assert.Equal(value1 || value2, result.Compile().Invoke(value1, value2));
                }
            }
        }
    }
}
