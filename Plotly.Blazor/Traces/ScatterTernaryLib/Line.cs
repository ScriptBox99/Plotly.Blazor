/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.ScatterTernaryLib
{
    /// <summary>
    ///     The Line class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Line : IEquatable<Line>
    {
        /// <summary>
        ///     Sets the line back off from the end point of the nth line segment (in px).
        ///     This option is useful e.g. to avoid overlap with arrowhead markers. With
        ///     <c>auto</c> the lines would trim before markers if <c>marker.angleref</c>
        ///     is set to <c>previous</c>.
        /// </summary>
        [JsonPropertyName(@"backoff")]
        public decimal? BackOff { get; set;} 

        /// <summary>
        ///     Sets the line back off from the end point of the nth line segment (in px).
        ///     This option is useful e.g. to avoid overlap with arrowhead markers. With
        ///     <c>auto</c> the lines would trim before markers if <c>marker.angleref</c>
        ///     is set to <c>previous</c>.
        /// </summary>
        [JsonPropertyName(@"backoff")]
        [Array]
        public IList<decimal?> BackOffArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>backoff</c>.
        /// </summary>
        [JsonPropertyName(@"backoffsrc")]
        public string BackoffSrc { get; set;} 

        /// <summary>
        ///     Sets the line color.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Sets the dash style of lines. Set to a dash type string (<c>solid</c>, <c>dot</c>,
        ///     <c>dash</c>, <c>longdash</c>, <c>dashdot</c>, or <c>longdashdot</c>) or
        ///     a dash length list in px (eg <c>5px,10px,2px,2px</c>).
        /// </summary>
        [JsonPropertyName(@"dash")]
        public string Dash { get; set;} 

        /// <summary>
        ///     Determines the line shape. With <c>spline</c> the lines are drawn using
        ///     spline interpolation. The other available values correspond to step-wise
        ///     line shapes.
        /// </summary>
        [JsonPropertyName(@"shape")]
        public Plotly.Blazor.Traces.ScatterTernaryLib.LineLib.ShapeEnum? Shape { get; set;} 

        /// <summary>
        ///     Has an effect only if <c>shape</c> is set to <c>spline</c> Sets the amount
        ///     of smoothing. <c>0</c> corresponds to no smoothing (equivalent to a <c>linear</c>
        ///     shape).
        /// </summary>
        [JsonPropertyName(@"smoothing")]
        public decimal? Smoothing { get; set;} 

        /// <summary>
        ///     Sets the line width (in px).
        /// </summary>
        [JsonPropertyName(@"width")]
        public decimal? Width { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Line other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Line other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    BackOff == other.BackOff ||
                    BackOff != null &&
                    BackOff.Equals(other.BackOff)
                ) && 
                (
                    Equals(BackOffArray, other.BackOffArray) ||
                    BackOffArray != null && other.BackOffArray != null &&
                    BackOffArray.SequenceEqual(other.BackOffArray)
                ) &&
                (
                    BackoffSrc == other.BackoffSrc ||
                    BackoffSrc != null &&
                    BackoffSrc.Equals(other.BackoffSrc)
                ) && 
                (
                    Color == other.Color ||
                    Color != null &&
                    Color.Equals(other.Color)
                ) && 
                (
                    Dash == other.Dash ||
                    Dash != null &&
                    Dash.Equals(other.Dash)
                ) && 
                (
                    Shape == other.Shape ||
                    Shape != null &&
                    Shape.Equals(other.Shape)
                ) && 
                (
                    Smoothing == other.Smoothing ||
                    Smoothing != null &&
                    Smoothing.Equals(other.Smoothing)
                ) && 
                (
                    Width == other.Width ||
                    Width != null &&
                    Width.Equals(other.Width)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (BackOff != null) hashCode = hashCode * 59 + BackOff.GetHashCode();
                if (BackOffArray != null) hashCode = hashCode * 59 + BackOffArray.GetHashCode();
                if (BackoffSrc != null) hashCode = hashCode * 59 + BackoffSrc.GetHashCode();
                if (Color != null) hashCode = hashCode * 59 + Color.GetHashCode();
                if (Dash != null) hashCode = hashCode * 59 + Dash.GetHashCode();
                if (Shape != null) hashCode = hashCode * 59 + Shape.GetHashCode();
                if (Smoothing != null) hashCode = hashCode * 59 + Smoothing.GetHashCode();
                if (Width != null) hashCode = hashCode * 59 + Width.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Line and the right Line.
        /// </summary>
        /// <param name="left">Left Line.</param>
        /// <param name="right">Right Line.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Line left, Line right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Line and the right Line.
        /// </summary>
        /// <param name="left">Left Line.</param>
        /// <param name="right">Right Line.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Line left, Line right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Line</returns>
        public Line DeepClone()
        {
            return this.Copy();
        }
    }
}