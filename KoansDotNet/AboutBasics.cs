using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace KoansDotNet
{
	[TestFixture]
	public class AboutAsserts
	{
		[Test]
		// We shall contemplate truth by testing reality, via asserts.
		public void test_assert_truth ()
		{
			Assert.True ( false ); // this should be true
		}
		
		[Test]
		// Enlightenment may be more easily achieved with appropriate messages.
		public void test_assert_with_message ()
		{
			Assert.True ( false, "This should be true -- please fix this" );
		}

		[Test]
		// To understand reality, we must compare our expectations against reality.
		public void test_assert_equality()
		{
			var expected = 3;
			var actual = 1 + 1;
			
			Assert.True ( expected == actual );
		}
		
		[Test]
		// Some ways of asserting equality are better than others.
		public void test_a_better_way_of_asserting_equality ()
		{
			var expected = 3;
			var actual = 1 + 1;
			
			Assert.AreEqual ( expected, actual );
		}

		[Test]
		// Sometimes we will ask you to fill in the values.
		public void test_fill_in_values ()
		{
			int? blank = null;
			Assert.AreEqual ( blank, 1 + 1 );
		}
	}
}
