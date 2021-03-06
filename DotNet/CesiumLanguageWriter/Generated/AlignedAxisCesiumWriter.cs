// This file was generated automatically by GenerateFromSchema.  Do NOT edit it.
// https://github.com/AnalyticalGraphicsInc/czml-writer

using CesiumLanguageWriter.Advanced;
using System;
using System.Collections.Generic;

namespace CesiumLanguageWriter
{
    /// <summary>
    /// Writes a <code>AlignedAxis</code> to a <see cref="CesiumOutputStream" />.  A <code>AlignedAxis</code> is an aligned axis represented by a unit vector which can optionally vary over time.
    /// </summary>
    public class AlignedAxisCesiumWriter : CesiumInterpolatablePropertyWriter<AlignedAxisCesiumWriter>
    {
        /// <summary>
        /// The name of the <code>unitCartesian</code> property.
        /// </summary>
        public const string UnitCartesianPropertyName = "unitCartesian";

        /// <summary>
        /// The name of the <code>unitSpherical</code> property.
        /// </summary>
        public const string UnitSphericalPropertyName = "unitSpherical";

        /// <summary>
        /// The name of the <code>reference</code> property.
        /// </summary>
        public const string ReferencePropertyName = "reference";

        /// <summary>
        /// The name of the <code>velocityReference</code> property.
        /// </summary>
        public const string VelocityReferencePropertyName = "velocityReference";

        private readonly Lazy<ICesiumInterpolatableValuePropertyWriter<UnitCartesian>> m_asUnitCartesian;
        private readonly Lazy<ICesiumInterpolatableValuePropertyWriter<UnitSpherical>> m_asUnitSpherical;
        private readonly Lazy<ICesiumValuePropertyWriter<Reference>> m_asReference;
        private readonly Lazy<ICesiumValuePropertyWriter<Reference>> m_asVelocityReference;

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public AlignedAxisCesiumWriter(string propertyName)
            : base(propertyName)
        {
            m_asUnitCartesian = new Lazy<ICesiumInterpolatableValuePropertyWriter<UnitCartesian>>(CreateUnitCartesianAdaptor, false);
            m_asUnitSpherical = new Lazy<ICesiumInterpolatableValuePropertyWriter<UnitSpherical>>(CreateUnitSphericalAdaptor, false);
            m_asReference = new Lazy<ICesiumValuePropertyWriter<Reference>>(CreateReferenceAdaptor, false);
            m_asVelocityReference = new Lazy<ICesiumValuePropertyWriter<Reference>>(CreateVelocityReferenceAdaptor, false);
        }

        /// <summary>
        /// Initializes a new instance as a copy of an existing instance.
        /// </summary>
        /// <param name="existingInstance">The existing instance to copy.</param>
        protected AlignedAxisCesiumWriter(AlignedAxisCesiumWriter existingInstance)
            : base(existingInstance)
        {
            m_asUnitCartesian = new Lazy<ICesiumInterpolatableValuePropertyWriter<UnitCartesian>>(CreateUnitCartesianAdaptor, false);
            m_asUnitSpherical = new Lazy<ICesiumInterpolatableValuePropertyWriter<UnitSpherical>>(CreateUnitSphericalAdaptor, false);
            m_asReference = new Lazy<ICesiumValuePropertyWriter<Reference>>(CreateReferenceAdaptor, false);
            m_asVelocityReference = new Lazy<ICesiumValuePropertyWriter<Reference>>(CreateVelocityReferenceAdaptor, false);
        }

        /// <inheritdoc />
        public override AlignedAxisCesiumWriter Clone()
        {
            return new AlignedAxisCesiumWriter(this);
        }

        /// <summary>
        /// Writes the value expressed as a <code>unitCartesian</code>, which is the axis specified as a three-dimensional unit magnitude Cartesian value `[X, Y, Z]`, in world coordinates.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteUnitCartesian(UnitCartesian value)
        {
            const string PropertyName = UnitCartesianPropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteUnitCartesian3(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <code>unitCartesian</code>, which is the axis specified as a three-dimensional unit magnitude Cartesian value `[X, Y, Z]`, in world coordinates.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteUnitCartesian(IList<JulianDate> dates, IList<UnitCartesian> values)
        {
            WriteUnitCartesian(dates, values, 0, dates.Count);
        }

        /// <summary>
        /// Writes the value expressed as a <code>unitCartesian</code>, which is the axis specified as a three-dimensional unit magnitude Cartesian value `[X, Y, Z]`, in world coordinates.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to use in the `values` collection.</param>
        /// <param name="length">The number of elements to use from the `values` collection.</param>
        public void WriteUnitCartesian(IList<JulianDate> dates, IList<UnitCartesian> values, int startIndex, int length)
        {
            const string PropertyName = UnitCartesianPropertyName;
            OpenIntervalIfNecessary();
            CesiumWritingHelper.WriteUnitCartesian3(Output, PropertyName, dates, values, startIndex, length);
        }

        /// <summary>
        /// Writes the value expressed as a <code>unitSpherical</code>, which is the axis specified as a unit spherical value `[Clock, Cone]`, in radians.  The clock angle is measured in the XY plane from the positive X axis toward the positive Y axis.  The cone angle is the angle from the positive Z axis toward the negative Z axis.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteUnitSpherical(UnitSpherical value)
        {
            const string PropertyName = UnitSphericalPropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteUnitSpherical(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <code>unitSpherical</code>, which is the axis specified as a unit spherical value `[Clock, Cone]`, in radians.  The clock angle is measured in the XY plane from the positive X axis toward the positive Y axis.  The cone angle is the angle from the positive Z axis toward the negative Z axis.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteUnitSpherical(IList<JulianDate> dates, IList<UnitSpherical> values)
        {
            WriteUnitSpherical(dates, values, 0, dates.Count);
        }

        /// <summary>
        /// Writes the value expressed as a <code>unitSpherical</code>, which is the axis specified as a unit spherical value `[Clock, Cone]`, in radians.  The clock angle is measured in the XY plane from the positive X axis toward the positive Y axis.  The cone angle is the angle from the positive Z axis toward the negative Z axis.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to use in the `values` collection.</param>
        /// <param name="length">The number of elements to use from the `values` collection.</param>
        public void WriteUnitSpherical(IList<JulianDate> dates, IList<UnitSpherical> values, int startIndex, int length)
        {
            const string PropertyName = UnitSphericalPropertyName;
            OpenIntervalIfNecessary();
            CesiumWritingHelper.WriteUnitSpherical(Output, PropertyName, dates, values, startIndex, length);
        }

        /// <summary>
        /// Writes the value expressed as a <code>reference</code>, which is the axis specified as a reference to another property.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteReference(Reference value)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <code>reference</code>, which is the axis specified as a reference to another property.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteReference(string value)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <code>reference</code>, which is the axis specified as a reference to another property.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteReference(string identifier, string propertyName)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, identifier, propertyName);
        }

        /// <summary>
        /// Writes the value expressed as a <code>reference</code>, which is the axis specified as a reference to another property.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteReference(string identifier, string[] propertyNames)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, identifier, propertyNames);
        }

        /// <summary>
        /// Writes the value expressed as a <code>velocityReference</code>, which is the axis specified as the normalized velocity vector of a position property. The reference must be to a `position` property.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteVelocityReference(Reference value)
        {
            const string PropertyName = VelocityReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <code>velocityReference</code>, which is the axis specified as the normalized velocity vector of a position property. The reference must be to a `position` property.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteVelocityReference(string value)
        {
            const string PropertyName = VelocityReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <code>velocityReference</code>, which is the axis specified as the normalized velocity vector of a position property. The reference must be to a `position` property.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteVelocityReference(string identifier, string propertyName)
        {
            const string PropertyName = VelocityReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, identifier, propertyName);
        }

        /// <summary>
        /// Writes the value expressed as a <code>velocityReference</code>, which is the axis specified as the normalized velocity vector of a position property. The reference must be to a `position` property.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteVelocityReference(string identifier, string[] propertyNames)
        {
            const string PropertyName = VelocityReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, identifier, propertyNames);
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumInterpolatableValuePropertyWriter{T}" /> to write a value in <code>UnitCartesian</code> format.  Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close" /> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public ICesiumInterpolatableValuePropertyWriter<UnitCartesian> AsUnitCartesian()
        {
            return m_asUnitCartesian.Value;
        }

        private ICesiumInterpolatableValuePropertyWriter<UnitCartesian> CreateUnitCartesianAdaptor()
        {
            return new CesiumInterpolatableWriterAdaptor<AlignedAxisCesiumWriter, UnitCartesian>(this, (me, value) => me.WriteUnitCartesian(value), (me, dates, values, startIndex, length) => me.WriteUnitCartesian(dates, values, startIndex, length));
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumInterpolatableValuePropertyWriter{T}" /> to write a value in <code>UnitSpherical</code> format.  Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close" /> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public ICesiumInterpolatableValuePropertyWriter<UnitSpherical> AsUnitSpherical()
        {
            return m_asUnitSpherical.Value;
        }

        private ICesiumInterpolatableValuePropertyWriter<UnitSpherical> CreateUnitSphericalAdaptor()
        {
            return new CesiumInterpolatableWriterAdaptor<AlignedAxisCesiumWriter, UnitSpherical>(this, (me, value) => me.WriteUnitSpherical(value), (me, dates, values, startIndex, length) => me.WriteUnitSpherical(dates, values, startIndex, length));
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumValuePropertyWriter{T}" /> to write a value in <code>Reference</code> format.  Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close" /> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public ICesiumValuePropertyWriter<Reference> AsReference()
        {
            return m_asReference.Value;
        }

        private ICesiumValuePropertyWriter<Reference> CreateReferenceAdaptor()
        {
            return new CesiumWriterAdaptor<AlignedAxisCesiumWriter, Reference>(this, (me, value) => me.WriteReference(value));
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumValuePropertyWriter{T}" /> to write a value in <code>VelocityReference</code> format.  Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close" /> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public ICesiumValuePropertyWriter<Reference> AsVelocityReference()
        {
            return m_asVelocityReference.Value;
        }

        private ICesiumValuePropertyWriter<Reference> CreateVelocityReferenceAdaptor()
        {
            return new CesiumWriterAdaptor<AlignedAxisCesiumWriter, Reference>(this, (me, value) => me.WriteVelocityReference(value));
        }

    }
}
