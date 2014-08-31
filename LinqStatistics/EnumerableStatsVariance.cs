﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqStatistics
{
    public static partial class EnumerableStats
    {
    	
        /// <summary>
        /// Computes the Variance of a sequence of nullable int values.
        /// </summary>
        /// <param name="source">A sequence of nullable int values to calculate the Variance of.</param>
        /// <returns>       
        ///     The Variance of the sequence of values, or null if the source sequence is
        ///     empty or contains only values that are null.
        /// </returns>
        public static double? Variance(this IEnumerable<int?> source)
        {
            IEnumerable<int> values = source.AllValues();
            if (values.Any())
                return values.Variance();
            
            return null;
        }

        /// <summary>
        /// Computes the Variance of a sequence of int values.
        /// </summary>
        /// <param name="source">A sequence of int values to calculate the Variance of.</param>
        /// <returns>       
        ///     The Variance of the sequence of values.
        /// </returns>
        public static double Variance(this IEnumerable<int> source)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (source.Count() < 2)
                throw new InvalidOperationException("Source must have at least 2 elements");

            int n = 0;
            double mean = 0;
            double M2 = 0;

            foreach (double x in source)
            {
                n = n + 1;
                double delta = x - mean;
                mean += delta / n;
                M2 += delta * (x - mean);
            }

            return (double)(M2 / (n - 1));
        }

        /// <summary>
        /// Computes the Variance of a sequence of nullable int values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>       
        ///     The Variance of the sequence of values.
        /// </returns>
        public static double? Variance<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).Variance();
        }

        /// <summary>
        /// Computes the Variance of a sequence of int values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>       
        ///     The Variance of the sequence of values.
        /// </returns>
        public static double Variance<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).Variance();
        }
 	
        /// <summary>
        /// Computes the Variance of a sequence of nullable long values.
        /// </summary>
        /// <param name="source">A sequence of nullable long values to calculate the Variance of.</param>
        /// <returns>       
        ///     The Variance of the sequence of values, or null if the source sequence is
        ///     empty or contains only values that are null.
        /// </returns>
        public static double? Variance(this IEnumerable<long?> source)
        {
            IEnumerable<long> values = source.AllValues();
            if (values.Any())
                return values.Variance();
            
            return null;
        }

        /// <summary>
        /// Computes the Variance of a sequence of long values.
        /// </summary>
        /// <param name="source">A sequence of long values to calculate the Variance of.</param>
        /// <returns>       
        ///     The Variance of the sequence of values.
        /// </returns>
        public static double Variance(this IEnumerable<long> source)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (source.Count() < 2)
                throw new InvalidOperationException("Source must have at least 2 elements");

            int n = 0;
            double mean = 0;
            double M2 = 0;

            foreach (double x in source)
            {
                n = n + 1;
                double delta = x - mean;
                mean += delta / n;
                M2 += delta * (x - mean);
            }

            return (double)(M2 / (n - 1));
        }

        /// <summary>
        /// Computes the Variance of a sequence of nullable long values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>       
        ///     The Variance of the sequence of values.
        /// </returns>
        public static double? Variance<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).Variance();
        }

        /// <summary>
        /// Computes the Variance of a sequence of long values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>       
        ///     The Variance of the sequence of values.
        /// </returns>
        public static double Variance<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).Variance();
        }
 	
        /// <summary>
        /// Computes the Variance of a sequence of nullable decimal values.
        /// </summary>
        /// <param name="source">A sequence of nullable decimal values to calculate the Variance of.</param>
        /// <returns>       
        ///     The Variance of the sequence of values, or null if the source sequence is
        ///     empty or contains only values that are null.
        /// </returns>
        public static decimal? Variance(this IEnumerable<decimal?> source)
        {
            IEnumerable<decimal> values = source.AllValues();
            if (values.Any())
                return values.Variance();
            
            return null;
        }

        /// <summary>
        /// Computes the Variance of a sequence of decimal values.
        /// </summary>
        /// <param name="source">A sequence of decimal values to calculate the Variance of.</param>
        /// <returns>       
        ///     The Variance of the sequence of values.
        /// </returns>
        public static decimal Variance(this IEnumerable<decimal> source)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (source.Count() < 2)
                throw new InvalidOperationException("Source must have at least 2 elements");

            int n = 0;
            double mean = 0;
            double M2 = 0;

            foreach (double x in source)
            {
                n = n + 1;
                double delta = x - mean;
                mean += delta / n;
                M2 += delta * (x - mean);
            }

            return (decimal)(M2 / (n - 1));
        }

        /// <summary>
        /// Computes the Variance of a sequence of nullable decimal values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>       
        ///     The Variance of the sequence of values.
        /// </returns>
        public static decimal? Variance<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).Variance();
        }

        /// <summary>
        /// Computes the Variance of a sequence of decimal values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>       
        ///     The Variance of the sequence of values.
        /// </returns>
        public static decimal Variance<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).Variance();
        }
 	
        /// <summary>
        /// Computes the Variance of a sequence of nullable float values.
        /// </summary>
        /// <param name="source">A sequence of nullable float values to calculate the Variance of.</param>
        /// <returns>       
        ///     The Variance of the sequence of values, or null if the source sequence is
        ///     empty or contains only values that are null.
        /// </returns>
        public static float? Variance(this IEnumerable<float?> source)
        {
            IEnumerable<float> values = source.AllValues();
            if (values.Any())
                return values.Variance();
            
            return null;
        }

        /// <summary>
        /// Computes the Variance of a sequence of float values.
        /// </summary>
        /// <param name="source">A sequence of float values to calculate the Variance of.</param>
        /// <returns>       
        ///     The Variance of the sequence of values.
        /// </returns>
        public static float Variance(this IEnumerable<float> source)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (source.Count() < 2)
                throw new InvalidOperationException("Source must have at least 2 elements");

            int n = 0;
            double mean = 0;
            double M2 = 0;

            foreach (double x in source)
            {
                n = n + 1;
                double delta = x - mean;
                mean += delta / n;
                M2 += delta * (x - mean);
            }

            return (float)(M2 / (n - 1));
        }

        /// <summary>
        /// Computes the Variance of a sequence of nullable float values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>       
        ///     The Variance of the sequence of values.
        /// </returns>
        public static float? Variance<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).Variance();
        }

        /// <summary>
        /// Computes the Variance of a sequence of float values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>       
        ///     The Variance of the sequence of values.
        /// </returns>
        public static float Variance<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).Variance();
        }
 	
        /// <summary>
        /// Computes the Variance of a sequence of nullable double values.
        /// </summary>
        /// <param name="source">A sequence of nullable double values to calculate the Variance of.</param>
        /// <returns>       
        ///     The Variance of the sequence of values, or null if the source sequence is
        ///     empty or contains only values that are null.
        /// </returns>
        public static double? Variance(this IEnumerable<double?> source)
        {
            IEnumerable<double> values = source.AllValues();
            if (values.Any())
                return values.Variance();
            
            return null;
        }

        /// <summary>
        /// Computes the Variance of a sequence of double values.
        /// </summary>
        /// <param name="source">A sequence of double values to calculate the Variance of.</param>
        /// <returns>       
        ///     The Variance of the sequence of values.
        /// </returns>
        public static double Variance(this IEnumerable<double> source)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (source.Count() < 2)
                throw new InvalidOperationException("Source must have at least 2 elements");

            int n = 0;
            double mean = 0;
            double M2 = 0;

            foreach (double x in source)
            {
                n = n + 1;
                double delta = x - mean;
                mean += delta / n;
                M2 += delta * (x - mean);
            }

            return (double)(M2 / (n - 1));
        }

        /// <summary>
        /// Computes the Variance of a sequence of nullable double values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>       
        ///     The Variance of the sequence of values.
        /// </returns>
        public static double? Variance<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).Variance();
        }

        /// <summary>
        /// Computes the Variance of a sequence of double values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>       
        ///     The Variance of the sequence of values.
        /// </returns>
        public static double Variance<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).Variance();
        }
     }
}