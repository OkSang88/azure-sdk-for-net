// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.TextAnalytics.Legacy.Models
{
    /// <summary> Healthcare Entity Category. </summary>
    internal readonly partial struct HealthcareEntityCategory : IEquatable<HealthcareEntityCategory>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HealthcareEntityCategory"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HealthcareEntityCategory(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BodyStructureValue = "BODY_STRUCTURE";
        private const string AGEValue = "AGE";
        private const string GenderValue = "GENDER";
        private const string ExaminationNameValue = "EXAMINATION_NAME";
        private const string DateValue = "DATE";
        private const string DirectionValue = "DIRECTION";
        private const string FrequencyValue = "FREQUENCY";
        private const string MeasurementValueValue = "MEASUREMENT_VALUE";
        private const string MeasurementUnitValue = "MEASUREMENT_UNIT";
        private const string RelationalOperatorValue = "RELATIONAL_OPERATOR";
        private const string TimeValue = "TIME";
        private const string GeneORProteinValue = "GENE_OR_PROTEIN";
        private const string VariantValue = "VARIANT";
        private const string AdministrativeEventValue = "ADMINISTRATIVE_EVENT";
        private const string CareEnvironmentValue = "CARE_ENVIRONMENT";
        private const string HealthcareProfessionValue = "HEALTHCARE_PROFESSION";
        private const string DiagnosisValue = "DIAGNOSIS";
        private const string SymptomORSignValue = "SYMPTOM_OR_SIGN";
        private const string ConditionQualifierValue = "CONDITION_QUALIFIER";
        private const string MedicationClassValue = "MEDICATION_CLASS";
        private const string MedicationNameValue = "MEDICATION_NAME";
        private const string DosageValue = "DOSAGE";
        private const string MedicationFormValue = "MEDICATION_FORM";
        private const string MedicationRouteValue = "MEDICATION_ROUTE";
        private const string FamilyRelationValue = "FAMILY_RELATION";
        private const string TreatmentNameValue = "TREATMENT_NAME";

        /// <summary> BODY_STRUCTURE. </summary>
        public static HealthcareEntityCategory BodyStructure { get; } = new HealthcareEntityCategory(BodyStructureValue);
        /// <summary> AGE. </summary>
        public static HealthcareEntityCategory AGE { get; } = new HealthcareEntityCategory(AGEValue);
        /// <summary> GENDER. </summary>
        public static HealthcareEntityCategory Gender { get; } = new HealthcareEntityCategory(GenderValue);
        /// <summary> EXAMINATION_NAME. </summary>
        public static HealthcareEntityCategory ExaminationName { get; } = new HealthcareEntityCategory(ExaminationNameValue);
        /// <summary> DATE. </summary>
        public static HealthcareEntityCategory Date { get; } = new HealthcareEntityCategory(DateValue);
        /// <summary> DIRECTION. </summary>
        public static HealthcareEntityCategory Direction { get; } = new HealthcareEntityCategory(DirectionValue);
        /// <summary> FREQUENCY. </summary>
        public static HealthcareEntityCategory Frequency { get; } = new HealthcareEntityCategory(FrequencyValue);
        /// <summary> MEASUREMENT_VALUE. </summary>
        public static HealthcareEntityCategory MeasurementValue { get; } = new HealthcareEntityCategory(MeasurementValueValue);
        /// <summary> MEASUREMENT_UNIT. </summary>
        public static HealthcareEntityCategory MeasurementUnit { get; } = new HealthcareEntityCategory(MeasurementUnitValue);
        /// <summary> RELATIONAL_OPERATOR. </summary>
        public static HealthcareEntityCategory RelationalOperator { get; } = new HealthcareEntityCategory(RelationalOperatorValue);
        /// <summary> TIME. </summary>
        public static HealthcareEntityCategory Time { get; } = new HealthcareEntityCategory(TimeValue);
        /// <summary> GENE_OR_PROTEIN. </summary>
        public static HealthcareEntityCategory GeneORProtein { get; } = new HealthcareEntityCategory(GeneORProteinValue);
        /// <summary> VARIANT. </summary>
        public static HealthcareEntityCategory Variant { get; } = new HealthcareEntityCategory(VariantValue);
        /// <summary> ADMINISTRATIVE_EVENT. </summary>
        public static HealthcareEntityCategory AdministrativeEvent { get; } = new HealthcareEntityCategory(AdministrativeEventValue);
        /// <summary> CARE_ENVIRONMENT. </summary>
        public static HealthcareEntityCategory CareEnvironment { get; } = new HealthcareEntityCategory(CareEnvironmentValue);
        /// <summary> HEALTHCARE_PROFESSION. </summary>
        public static HealthcareEntityCategory HealthcareProfession { get; } = new HealthcareEntityCategory(HealthcareProfessionValue);
        /// <summary> DIAGNOSIS. </summary>
        public static HealthcareEntityCategory Diagnosis { get; } = new HealthcareEntityCategory(DiagnosisValue);
        /// <summary> SYMPTOM_OR_SIGN. </summary>
        public static HealthcareEntityCategory SymptomORSign { get; } = new HealthcareEntityCategory(SymptomORSignValue);
        /// <summary> CONDITION_QUALIFIER. </summary>
        public static HealthcareEntityCategory ConditionQualifier { get; } = new HealthcareEntityCategory(ConditionQualifierValue);
        /// <summary> MEDICATION_CLASS. </summary>
        public static HealthcareEntityCategory MedicationClass { get; } = new HealthcareEntityCategory(MedicationClassValue);
        /// <summary> MEDICATION_NAME. </summary>
        public static HealthcareEntityCategory MedicationName { get; } = new HealthcareEntityCategory(MedicationNameValue);
        /// <summary> DOSAGE. </summary>
        public static HealthcareEntityCategory Dosage { get; } = new HealthcareEntityCategory(DosageValue);
        /// <summary> MEDICATION_FORM. </summary>
        public static HealthcareEntityCategory MedicationForm { get; } = new HealthcareEntityCategory(MedicationFormValue);
        /// <summary> MEDICATION_ROUTE. </summary>
        public static HealthcareEntityCategory MedicationRoute { get; } = new HealthcareEntityCategory(MedicationRouteValue);
        /// <summary> FAMILY_RELATION. </summary>
        public static HealthcareEntityCategory FamilyRelation { get; } = new HealthcareEntityCategory(FamilyRelationValue);
        /// <summary> TREATMENT_NAME. </summary>
        public static HealthcareEntityCategory TreatmentName { get; } = new HealthcareEntityCategory(TreatmentNameValue);
        /// <summary> Determines if two <see cref="HealthcareEntityCategory"/> values are the same. </summary>
        public static bool operator ==(HealthcareEntityCategory left, HealthcareEntityCategory right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HealthcareEntityCategory"/> values are not the same. </summary>
        public static bool operator !=(HealthcareEntityCategory left, HealthcareEntityCategory right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HealthcareEntityCategory"/>. </summary>
        public static implicit operator HealthcareEntityCategory(string value) => new HealthcareEntityCategory(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HealthcareEntityCategory other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HealthcareEntityCategory other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
