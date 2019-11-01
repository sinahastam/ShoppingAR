using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public partial class ProductDataClass
{
    public Product Product { get; set; }
    public long Status { get; set; }
    public string StatusVerbose { get; set; }
    public string Code { get; set; }
}

[Serializable]
public partial class Product
{
    public Uri ImageNutritionSmallUrl { get; set; }
    public List<object> IngredientsTextFrDebugTags { get; set; }
    public List<object> ProductNameFrDebugTags { get; set; }
    public long NutritionScoreWarningNoFruitsVegetablesNuts { get; set; }
    public List<object> AminoAcidsTags { get; set; }
    public string NoNutritionData { get; set; }
    public double Completeness { get; set; }
    public long NovaGroups { get; set; }
    public string ConservationConditionsFr { get; set; }
    public long NetWeightValue { get; set; }
    public long Rev { get; set; }
    public List<string> NovaGroupsTags { get; set; }
    public NutrientLevels NutrientLevels { get; set; }
    public string LabelsLc { get; set; }
    public long CompletedT { get; set; }
    public List<object> PackagingDebugTags { get; set; }
    public List<object> NucleotidesTags { get; set; }
    public List<string> StoresTags { get; set; }
    public List<string> CodesTags { get; set; }
    public long CreatedT { get; set; }
    public string CategoriesLc { get; set; }
    public List<object> TracesDebugTags { get; set; }
    public string Stores { get; set; }
    public List<string> LastImageDatesTags { get; set; }
    public List<object> ManufacturingPlacesDebugTags { get; set; }
    public LanguagesCodes LanguagesCodes { get; set; }
    public List<object> MineralsTags { get; set; }
    public string NutritionGradeFrProducer { get; set; }
    public List<object> LinkDebugTags { get; set; }
    public string PurchasePlaces { get; set; }
    public string Lc { get; set; }
    public string IngredientsText { get; set; }
    public List<string> NutritionGradesTags { get; set; }
    public long ServingQuantity { get; set; }
    public string RecyclingInstructionsToDiscard { get; set; }
    public string NetWeightUnit { get; set; }
    public List<string> StatesHierarchy { get; set; }
    public long IngredientsFromOrThatMayBeFromPalmOilN { get; set; }
    public string Packaging { get; set; }
    public string IngredientsTextFr { get; set; }
    public string Origins { get; set; }
    public string Link { get; set; }
    public string Code { get; set; }
    public List<object> UnknownNutrientsTags { get; set; }
    public List<object> VitaminsTags { get; set; }
    public string ProductNameFr { get; set; }
    public Uri ImageThumbUrl { get; set; }
    public List<string> AdditivesTags { get; set; }
    public Languages Languages { get; set; }
    public Nutriments Nutriments { get; set; }
    public string Quantity { get; set; }
    public List<string> AdditivesOriginalTags { get; set; }
    public string NutritionScoreDebug { get; set; }
    public List<string> PurchasePlacesTags { get; set; }
    public Uri ImageNutritionUrl { get; set; }
    public string PnnsGroups2 { get; set; }
    public string ProductId { get; set; }
    public string Id { get; set; }
    public Uri ImageIngredientsThumbUrl { get; set; }
    public List<object> IngredientsFromPalmOilTags { get; set; }
    public List<string> LabelsPrevTags { get; set; }
    public string ExpirationDate { get; set; }
    public List<string> DataSourcesTags { get; set; }
    public List<object> CitiesTags { get; set; }
    public List<string> AdditivesOldTags { get; set; }
    public string Labels { get; set; }
    public List<string> EntryDatesTags { get; set; }
    public List<object> VitaminsPrevTags { get; set; }
    public Uri ImageFrontUrl { get; set; }
    public string NovaGroupDebug { get; set; }
    public List<string> IngredientsOriginalTags { get; set; }
    public string Allergens { get; set; }
    public List<object> ManufacturingPlacesTags { get; set; }
    public List<object> OtherNutritionalSubstancesTags { get; set; }
    public long FruitsVegetablesNuts100GEstimate { get; set; }
    public List<string> CorrectorsTags { get; set; }
    public Uri ImageNutritionThumbUrl { get; set; }
    public string IngredientsTextDebug { get; set; }
    public List<object> OriginsTags { get; set; }
    public List<string> LabelsHierarchy { get; set; }
    public string OtherInformationFr { get; set; }
    public string NutritionGrades { get; set; }
    public string EmbCodesOrig { get; set; }
    public Uri ImageSmallUrl { get; set; }
    public string DataSources { get; set; }
    public string ServingSize { get; set; }
    public long IngredientsN { get; set; }
    public List<string> PhotographersTags { get; set; }
    public List<object> CheckersTags { get; set; }
    public List<string> CountriesHierarchy { get; set; }
    public List<string> IngredientsHierarchy { get; set; }
    public string EmbCodes { get; set; }
    public Uri ImageFrontSmallUrl { get; set; }
    public string GenericNameFr { get; set; }
    public List<string> DebugParamSortedLangs { get; set; }
    public List<string> PnnsGroups2_Tags { get; set; }
    public List<string> LabelsTags { get; set; }
    public string NutritionDataPer { get; set; }
    public Uri ImageUrl { get; set; }
    public string Creator { get; set; }
    public string InterfaceVersionCreated { get; set; }
    public long NovaGroup { get; set; }
    public List<string> TracesTags { get; set; }
    public string GenericName { get; set; }
    public List<string> LabelsDebugTags { get; set; }
    public long LastModifiedT { get; set; }
    public string NutritionGradeFr { get; set; }
    public List<string> IngredientsTags { get; set; }
    public List<string> LanguagesHierarchy { get; set; }
    public List<object> OriginsDebugTags { get; set; }
    public string UpdateKey { get; set; }
    public Uri ImageFrontThumbUrl { get; set; }
    public List<Source> Sources { get; set; }
    public List<string> PnnsGroups1_Tags { get; set; }
    public List<object> EmbCodesTags { get; set; }
    public string Lang { get; set; }
    public long Complete { get; set; }
    public List<string> InformersTags { get; set; }
    public List<object> CountriesDebugTags { get; set; }
    public List<string> PackagingTags { get; set; }
    public List<object> NucleotidesPrevTags { get; set; }
    public List<object> NutritionDataPerDebugTags { get; set; }
    public string CarbonFootprintFromKnownIngredientsDebug { get; set; }
    public List<string> LastEditDatesTags { get; set; }
    public string OtherInformation { get; set; }
    public List<object> PurchasePlacesDebugTags { get; set; }
    public List<string> IngredientsIdsDebug { get; set; }
    public List<string> IngredientsNTags { get; set; }
    public List<string> QualityTags { get; set; }
    public List<object> BrandsDebugTags { get; set; }
    public long LastImageT { get; set; }
    public List<string> TracesHierarchy { get; set; }
    public long AdditivesN { get; set; }
    public List<string> LanguagesTags { get; set; }
    public List<object> MineralsPrevTags { get; set; }
    public List<object> QuantityDebugTags { get; set; }
    public long ProductQuantity { get; set; }
    public long MaxImgid { get; set; }
    public string RecyclingInstructionsToDiscardFr { get; set; }
    public List<object> AminoAcidsPrevTags { get; set; }
    public string IngredientsTextWithAllergens { get; set; }
    public List<string> Keywords { get; set; }
    public Uri ImageIngredientsUrl { get; set; }
    public List<object> LangDebugTags { get; set; }
    public List<string> CategoriesHierarchy { get; set; }
    public List<object> IngredientsThatMayBeFromPalmOilTags { get; set; }
    public long UnknownIngredientsN { get; set; }
    public double CarbonFootprintPercentOfKnownIngredients { get; set; }
    public string PnnsGroups1 { get; set; }
    public List<string> CategoriesTags { get; set; }
    public List<string> AllergensTags { get; set; }
    public string Brands { get; set; }
    public long NutritionScoreWarningNoFiber { get; set; }
    public long NutritionScoreBeverage { get; set; }
    public List<string> IngredientsAnalysisTags { get; set; }
    public Images Images { get; set; }
    public string States { get; set; }
    public string ProductName { get; set; }
    public long IngredientsThatMayBeFromPalmOilN { get; set; }
    public List<string> AdditivesDebugTags { get; set; }
    public string ProducerVersionId { get; set; }
    public string CountriesLc { get; set; }
    public List<object> StoresDebugTags { get; set; }
    public Uri ImageIngredientsSmallUrl { get; set; }
    public List<string> AdditivesPrevOriginalTags { get; set; }
    public string Categories { get; set; }
    public string LastModifiedBy { get; set; }
    public string ConservationConditions { get; set; }
    public string LastEditor { get; set; }
    public string InterfaceVersionModified { get; set; }
    public List<Ingredient> Ingredients { get; set; }
    public List<string> LabelsPrevHierarchy { get; set; }
    public List<string> MiscTags { get; set; }
    public long AdditivesOldN { get; set; }
    public string AllergensFromIngredients { get; set; }
    public SelectedImages SelectedImages { get; set; }
    public List<string> StatesTags { get; set; }
    public string NutritionDataPreparedPer { get; set; }
    public List<string> EditorsTags { get; set; }
    public string Traces { get; set; }
    public string ManufacturingPlaces { get; set; }
    public List<object> EmbCodesDebugTags { get; set; }
    public string IngredientsTextWithAllergensFr { get; set; }
    public List<string> NutrientLevelsTags { get; set; }
    public string TracesFromIngredients { get; set; }
    public List<object> ExpirationDateDebugTags { get; set; }
    public List<object> ServingSizeDebugTags { get; set; }
    public List<string> AllergensHierarchy { get; set; }
    public List<string> BrandsTags { get; set; }
    public List<string> IngredientsDebug { get; set; }
    public List<string> CountriesTags { get; set; }
    public string Countries { get; set; }
    public List<object> GenericNameFrDebugTags { get; set; }
    public long IngredientsFromPalmOilN { get; set; }
    public long Sortkey { get; set; }
}

[Serializable]
public partial class Images
{
    public The1 The1 { get; set; }
    public The1 The2 { get; set; }
    public The1 The3 { get; set; }
    public The1 The4 { get; set; }
    public The1 The5 { get; set; }
    public Fr IngredientsFr { get; set; }
    public Fr NutritionFr { get; set; }
    public Fr FrontFr { get; set; }
}

[Serializable]
public partial class Fr
{
    public string Geometry { get; set; }
    public long Rev { get; set; }
    public long Angle { get; set; }
    public string X2 { get; set; }
    public string Y2 { get; set; }
    public long Imgid { get; set; }
    public bool WhiteMagic { get; set; }
    public string X1 { get; set; }
    public bool Normalize { get; set; }
    public string Y1 { get; set; }
    public Sizes Sizes { get; set; }
}

[Serializable]
public partial class Sizes
{
    public The100 The100 { get; set; }
    public The100 The400 { get; set; }
    public The100 Full { get; set; }
    public The100 The200 { get; set; }
}

[Serializable]
public partial class The100
{
    public long W { get; set; }
    public long H { get; set; }
}

[Serializable]
public partial class The1
{
    public string Uploader { get; set; }
    public Sizes Sizes { get; set; }
    public long UploadedT { get; set; }
}

[Serializable]
public partial class Ingredient
{
    public string Percent { get; set; }
    public long? Rank { get; set; }
    public string Id { get; set; }
    public string Text { get; set; }
    public FromPalmOil? Vegetarian { get; set; }
    public FromPalmOil? Vegan { get; set; }
    public FromPalmOil? FromPalmOil { get; set; }
    public string Origin { get; set; }
}

[Serializable]
public partial class Languages
{
    public long EnFrench { get; set; }
}

[Serializable]
public partial class LanguagesCodes
{
    public long Fr { get; set; }
}

[Serializable]
public partial class NutrientLevels
{
    public string Salt { get; set; }
    public string Sugars { get; set; }
    public string SaturatedFat { get; set; }
    public string Fat { get; set; }
}

[Serializable]
public partial class Nutriments
{
    public string SaturatedFatUnit { get; set; }
    public long NutritionScoreFrProducerServing { get; set; }
    public long NutritionScoreFr { get; set; }
    public long Energy100G { get; set; }
    public long NutritionScoreFrProducerValue { get; set; }
    public long NutritionScoreFrServing { get; set; }
    public string SugarsUnit { get; set; }
    public double Sodium100G { get; set; }
    public long CarbonFootprintFromKnownIngredientsProduct { get; set; }
    public long NutritionScoreUk { get; set; }
    public double SugarsServing { get; set; }
    public long Carbohydrates { get; set; }
    public long NutritionScoreUk100G { get; set; }
    public double SaltServing { get; set; }
    public double Sugars { get; set; }
    public double Sugars100G { get; set; }
    public string EnergyUnit { get; set; }
    public long FatValue { get; set; }
    public long Energy { get; set; }
    public double SaltValue { get; set; }
    public long NovaGroup { get; set; }
    public double SaturatedFat { get; set; }
    public long NovaGroupServing { get; set; }
    public double CarbonFootprintFromKnownIngredients100G { get; set; }
    public string CarbohydratesUnit { get; set; }
    public double SugarsValue { get; set; }
    public long NutritionScoreFr100G { get; set; }
    public long CarbohydratesServing { get; set; }
    public double Proteins100G { get; set; }
    public double NutritionScoreFrProducer100G { get; set; }
    public long NovaGroup100G { get; set; }
    public string SodiumUnit { get; set; }
    public long NutritionScoreFrProducer { get; set; }
    public double Carbohydrates100G { get; set; }
    public long FatServing { get; set; }
    public double Salt { get; set; }
    public double SodiumServing { get; set; }
    public long ProteinsServing { get; set; }
    public double SaturatedFat100G { get; set; }
    public double SaturatedFatServing { get; set; }
    public long CarbohydratesValue { get; set; }
    public string NutritionScoreFrProducerUnit { get; set; }
    public long Proteins { get; set; }
    public double Salt100G { get; set; }
    public long NutritionScoreUkServing { get; set; }
    public string ProteinsUnit { get; set; }
    public double SodiumValue { get; set; }
    public double SaturatedFatValue { get; set; }
    public long Fat { get; set; }
    public string SaltUnit { get; set; }
    public string FatUnit { get; set; }
    public long ProteinsValue { get; set; }
    public double Fat100G { get; set; }
    public double Sodium { get; set; }
    public long EnergyServing { get; set; }
    public long CarbonFootprintFromKnownIngredientsServing { get; set; }
    public long EnergyValue { get; set; }
}

[Serializable]
public partial class SelectedImages
{
    public Front Front { get; set; }
    public Front Nutrition { get; set; }
    public Front Ingredients { get; set; }
}

[Serializable]
public partial class Front
{
    public Display Display { get; set; }
    public Display Thumb { get; set; }
    public Display Small { get; set; }
}

[Serializable]
public partial class Display
{
    public Uri Fr { get; set; }
}

[Serializable]
public partial class Source
{
    public long ImportT { get; set; }
    public List<string> Fields { get; set; }
    public string Name { get; set; }
    public string Id { get; set; }
    public long Manufacturer { get; set; }
    public List<object> Images { get; set; }
    public Uri Url { get; set; }
}

[Serializable]
public enum FromPalmOil { Maybe, No, Yes };
