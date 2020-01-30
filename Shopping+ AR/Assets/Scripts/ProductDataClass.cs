// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using OpenFoodFactsAPIData;
//
//    var productDataClass = ProductDataClass.FromJson(jsonString);
//    Auto-Generated class from API response

namespace OpenFoodFactsAPIData
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;


    /// <summary>
    /// Class for storing/handling all API data of a product from OpenFoodFacts
    /// </summary>
    public partial class ProductDataClass
    {
        [JsonProperty("product", NullValueHandling = NullValueHandling.Ignore)]
        public Product Product { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public long? Status { get; set; }

        [JsonProperty("status_verbose", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusVerbose { get; set; }

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }
    }

    public partial class Product
    {
        [JsonProperty("image_nutrition_small_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ImageNutritionSmallUrl { get; set; }

        [JsonProperty("ingredients_text_fr_debug_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> IngredientsTextFrDebugTags { get; set; }

        [JsonProperty("product_name_fr_debug_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> ProductNameFrDebugTags { get; set; }

        [JsonProperty("nutrition_score_warning_no_fruits_vegetables_nuts", NullValueHandling = NullValueHandling.Ignore)]
        public long? NutritionScoreWarningNoFruitsVegetablesNuts { get; set; }

        [JsonProperty("amino_acids_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> AminoAcidsTags { get; set; }

        [JsonProperty("no_nutrition_data", NullValueHandling = NullValueHandling.Ignore)]
        public string NoNutritionData { get; set; }

        [JsonProperty("completeness", NullValueHandling = NullValueHandling.Ignore)]
        public double? Completeness { get; set; }

        [JsonProperty("nova_groups", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? NovaGroups { get; set; }

        [JsonProperty("conservation_conditions_fr", NullValueHandling = NullValueHandling.Ignore)]
        public string ConservationConditionsFr { get; set; }

        [JsonProperty("net_weight_value", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? NetWeightValue { get; set; }

        [JsonProperty("rev", NullValueHandling = NullValueHandling.Ignore)]
        public long? Rev { get; set; }

        [JsonProperty("nova_groups_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NovaGroupsTags { get; set; }

        [JsonProperty("nutrient_levels", NullValueHandling = NullValueHandling.Ignore)]
        public NutrientLevels NutrientLevels { get; set; }

        [JsonProperty("labels_lc", NullValueHandling = NullValueHandling.Ignore)]
        public string LabelsLc { get; set; }

        [JsonProperty("completed_t", NullValueHandling = NullValueHandling.Ignore)]
        public long? CompletedT { get; set; }

        [JsonProperty("packaging_debug_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> PackagingDebugTags { get; set; }

        [JsonProperty("nucleotides_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> NucleotidesTags { get; set; }

        [JsonProperty("stores_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> StoresTags { get; set; }

        [JsonProperty("codes_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CodesTags { get; set; }

        [JsonProperty("created_t", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreatedT { get; set; }

        [JsonProperty("categories_lc", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoriesLc { get; set; }

        [JsonProperty("traces_debug_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> TracesDebugTags { get; set; }

        [JsonProperty("stores", NullValueHandling = NullValueHandling.Ignore)]
        public string Stores { get; set; }

        [JsonProperty("last_image_dates_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LastImageDatesTags { get; set; }

        [JsonProperty("manufacturing_places_debug_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> ManufacturingPlacesDebugTags { get; set; }

        [JsonProperty("languages_codes", NullValueHandling = NullValueHandling.Ignore)]
        public LanguagesCodes LanguagesCodes { get; set; }

        [JsonProperty("minerals_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> MineralsTags { get; set; }

        [JsonProperty("nutrition_grade_fr_producer", NullValueHandling = NullValueHandling.Ignore)]
        public string NutritionGradeFrProducer { get; set; }

        [JsonProperty("link_debug_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> LinkDebugTags { get; set; }

        [JsonProperty("purchase_places", NullValueHandling = NullValueHandling.Ignore)]
        public string PurchasePlaces { get; set; }

        [JsonProperty("lc", NullValueHandling = NullValueHandling.Ignore)]
        public string Lc { get; set; }

        [JsonProperty("ingredients_text", NullValueHandling = NullValueHandling.Ignore)]
        public string IngredientsText { get; set; }

        [JsonProperty("nutrition_grades_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NutritionGradesTags { get; set; }

        [JsonProperty("serving_quantity", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? ServingQuantity { get; set; }

        [JsonProperty("recycling_instructions_to_discard", NullValueHandling = NullValueHandling.Ignore)]
        public string RecyclingInstructionsToDiscard { get; set; }

        [JsonProperty("net_weight_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string NetWeightUnit { get; set; }

        [JsonProperty("states_hierarchy", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> StatesHierarchy { get; set; }

        [JsonProperty("ingredients_from_or_that_may_be_from_palm_oil_n", NullValueHandling = NullValueHandling.Ignore)]
        public long? IngredientsFromOrThatMayBeFromPalmOilN { get; set; }

        [JsonProperty("packaging", NullValueHandling = NullValueHandling.Ignore)]
        public string Packaging { get; set; }

        [JsonProperty("ingredients_text_fr", NullValueHandling = NullValueHandling.Ignore)]
        public string IngredientsTextFr { get; set; }

        [JsonProperty("origins", NullValueHandling = NullValueHandling.Ignore)]
        public string Origins { get; set; }

        [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
        public string Link { get; set; }

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        [JsonProperty("unknown_nutrients_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> UnknownNutrientsTags { get; set; }

        [JsonProperty("vitamins_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> VitaminsTags { get; set; }

        [JsonProperty("product_name_fr", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductNameFr { get; set; }

        [JsonProperty("image_thumb_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ImageThumbUrl { get; set; }

        [JsonProperty("additives_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AdditivesTags { get; set; }

        [JsonProperty("languages", NullValueHandling = NullValueHandling.Ignore)]
        public Languages Languages { get; set; }

        [JsonProperty("nutriments", NullValueHandling = NullValueHandling.Ignore)]
        public Nutriments Nutriments { get; set; }

        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public string Quantity { get; set; }

        [JsonProperty("additives_original_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AdditivesOriginalTags { get; set; }

        [JsonProperty("nutrition_score_debug", NullValueHandling = NullValueHandling.Ignore)]
        public string NutritionScoreDebug { get; set; }

        [JsonProperty("purchase_places_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PurchasePlacesTags { get; set; }

        [JsonProperty("image_nutrition_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ImageNutritionUrl { get; set; }

        [JsonProperty("pnns_groups_2", NullValueHandling = NullValueHandling.Ignore)]
        public string PnnsGroups2 { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        [JsonProperty("_id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("image_ingredients_thumb_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ImageIngredientsThumbUrl { get; set; }

        [JsonProperty("ingredients_from_palm_oil_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> IngredientsFromPalmOilTags { get; set; }

        [JsonProperty("labels_prev_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LabelsPrevTags { get; set; }

        [JsonProperty("expiration_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpirationDate { get; set; }

        [JsonProperty("data_sources_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DataSourcesTags { get; set; }

        [JsonProperty("cities_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> CitiesTags { get; set; }

        [JsonProperty("additives_old_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AdditivesOldTags { get; set; }

        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public string Labels { get; set; }

        [JsonProperty("entry_dates_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EntryDatesTags { get; set; }

        [JsonProperty("vitamins_prev_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> VitaminsPrevTags { get; set; }

        [JsonProperty("image_front_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ImageFrontUrl { get; set; }

        [JsonProperty("nova_group_debug", NullValueHandling = NullValueHandling.Ignore)]
        public string NovaGroupDebug { get; set; }

        [JsonProperty("ingredients_original_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IngredientsOriginalTags { get; set; }

        [JsonProperty("allergens", NullValueHandling = NullValueHandling.Ignore)]
        public string Allergens { get; set; }

        [JsonProperty("manufacturing_places_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> ManufacturingPlacesTags { get; set; }

        [JsonProperty("other_nutritional_substances_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> OtherNutritionalSubstancesTags { get; set; }

        [JsonProperty("fruits-vegetables-nuts_100g_estimate", NullValueHandling = NullValueHandling.Ignore)]
        public long? FruitsVegetablesNuts100GEstimate { get; set; }

        [JsonProperty("correctors_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CorrectorsTags { get; set; }

        [JsonProperty("image_nutrition_thumb_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ImageNutritionThumbUrl { get; set; }

        [JsonProperty("ingredients_text_debug", NullValueHandling = NullValueHandling.Ignore)]
        public string IngredientsTextDebug { get; set; }

        [JsonProperty("origins_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> OriginsTags { get; set; }

        [JsonProperty("labels_hierarchy", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LabelsHierarchy { get; set; }

        [JsonProperty("other_information_fr", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherInformationFr { get; set; }

        [JsonProperty("nutrition_grades", NullValueHandling = NullValueHandling.Ignore)]
        public string NutritionGrades { get; set; }

        [JsonProperty("emb_codes_orig", NullValueHandling = NullValueHandling.Ignore)]
        public string EmbCodesOrig { get; set; }

        [JsonProperty("image_small_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ImageSmallUrl { get; set; }

        [JsonProperty("data_sources", NullValueHandling = NullValueHandling.Ignore)]
        public string DataSources { get; set; }

        [JsonProperty("serving_size", NullValueHandling = NullValueHandling.Ignore)]
        public string ServingSize { get; set; }

        [JsonProperty("ingredients_n", NullValueHandling = NullValueHandling.Ignore)]
        public long? IngredientsN { get; set; }

        [JsonProperty("photographers_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PhotographersTags { get; set; }

        [JsonProperty("checkers_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> CheckersTags { get; set; }

        [JsonProperty("countries_hierarchy", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CountriesHierarchy { get; set; }

        [JsonProperty("ingredients_hierarchy", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IngredientsHierarchy { get; set; }

        [JsonProperty("emb_codes", NullValueHandling = NullValueHandling.Ignore)]
        public string EmbCodes { get; set; }

        [JsonProperty("image_front_small_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ImageFrontSmallUrl { get; set; }

        [JsonProperty("generic_name_fr", NullValueHandling = NullValueHandling.Ignore)]
        public string GenericNameFr { get; set; }

        [JsonProperty("debug_param_sorted_langs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DebugParamSortedLangs { get; set; }

        [JsonProperty("pnns_groups_2_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PnnsGroups2_Tags { get; set; }

        [JsonProperty("labels_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LabelsTags { get; set; }

        [JsonProperty("nutrition_data_per", NullValueHandling = NullValueHandling.Ignore)]
        public string NutritionDataPer { get; set; }

        [JsonProperty("image_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ImageUrl { get; set; }

        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public string Creator { get; set; }

        [JsonProperty("interface_version_created", NullValueHandling = NullValueHandling.Ignore)]
        public string InterfaceVersionCreated { get; set; }

        [JsonProperty("nova_group", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? NovaGroup { get; set; }

        [JsonProperty("traces_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TracesTags { get; set; }

        [JsonProperty("generic_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GenericName { get; set; }

        [JsonProperty("labels_debug_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LabelsDebugTags { get; set; }

        [JsonProperty("last_modified_t", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastModifiedT { get; set; }

        [JsonProperty("nutrition_grade_fr", NullValueHandling = NullValueHandling.Ignore)]
        public string NutritionGradeFr { get; set; }

        [JsonProperty("ingredients_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IngredientsTags { get; set; }

        [JsonProperty("languages_hierarchy", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LanguagesHierarchy { get; set; }

        [JsonProperty("origins_debug_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> OriginsDebugTags { get; set; }

        [JsonProperty("update_key", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateKey { get; set; }

        [JsonProperty("image_front_thumb_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ImageFrontThumbUrl { get; set; }

        [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
        public List<Source> Sources { get; set; }

        [JsonProperty("pnns_groups_1_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PnnsGroups1_Tags { get; set; }

        [JsonProperty("emb_codes_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> EmbCodesTags { get; set; }

        [JsonProperty("lang", NullValueHandling = NullValueHandling.Ignore)]
        public string Lang { get; set; }

        [JsonProperty("complete", NullValueHandling = NullValueHandling.Ignore)]
        public long? Complete { get; set; }

        [JsonProperty("informers_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InformersTags { get; set; }

        [JsonProperty("countries_debug_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> CountriesDebugTags { get; set; }

        [JsonProperty("packaging_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PackagingTags { get; set; }

        [JsonProperty("nucleotides_prev_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> NucleotidesPrevTags { get; set; }

        [JsonProperty("nutrition_data_per_debug_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> NutritionDataPerDebugTags { get; set; }

        [JsonProperty("carbon_footprint_from_known_ingredients_debug", NullValueHandling = NullValueHandling.Ignore)]
        public string CarbonFootprintFromKnownIngredientsDebug { get; set; }

        [JsonProperty("last_edit_dates_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LastEditDatesTags { get; set; }

        [JsonProperty("other_information", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherInformation { get; set; }

        [JsonProperty("purchase_places_debug_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> PurchasePlacesDebugTags { get; set; }

        [JsonProperty("ingredients_ids_debug", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IngredientsIdsDebug { get; set; }

        [JsonProperty("ingredients_n_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IngredientsNTags { get; set; }

        [JsonProperty("quality_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> QualityTags { get; set; }

        [JsonProperty("brands_debug_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> BrandsDebugTags { get; set; }

        [JsonProperty("last_image_t", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastImageT { get; set; }

        [JsonProperty("traces_hierarchy", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TracesHierarchy { get; set; }

        [JsonProperty("additives_n", NullValueHandling = NullValueHandling.Ignore)]
        public long? AdditivesN { get; set; }

        [JsonProperty("languages_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LanguagesTags { get; set; }

        [JsonProperty("minerals_prev_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> MineralsPrevTags { get; set; }

        [JsonProperty("quantity_debug_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> QuantityDebugTags { get; set; }

        [JsonProperty("product_quantity", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? ProductQuantity { get; set; }

        [JsonProperty("max_imgid", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? MaxImgid { get; set; }

        [JsonProperty("recycling_instructions_to_discard_fr", NullValueHandling = NullValueHandling.Ignore)]
        public string RecyclingInstructionsToDiscardFr { get; set; }

        [JsonProperty("amino_acids_prev_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> AminoAcidsPrevTags { get; set; }

        [JsonProperty("ingredients_text_with_allergens", NullValueHandling = NullValueHandling.Ignore)]
        public string IngredientsTextWithAllergens { get; set; }

        [JsonProperty("_keywords", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Keywords { get; set; }

        [JsonProperty("image_ingredients_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ImageIngredientsUrl { get; set; }

        [JsonProperty("lang_debug_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> LangDebugTags { get; set; }

        [JsonProperty("categories_hierarchy", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CategoriesHierarchy { get; set; }

        [JsonProperty("ingredients_that_may_be_from_palm_oil_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> IngredientsThatMayBeFromPalmOilTags { get; set; }

        [JsonProperty("unknown_ingredients_n", NullValueHandling = NullValueHandling.Ignore)]
        public long? UnknownIngredientsN { get; set; }

        [JsonProperty("carbon_footprint_percent_of_known_ingredients", NullValueHandling = NullValueHandling.Ignore)]
        public double? CarbonFootprintPercentOfKnownIngredients { get; set; }

        [JsonProperty("pnns_groups_1", NullValueHandling = NullValueHandling.Ignore)]
        public string PnnsGroups1 { get; set; }

        [JsonProperty("categories_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CategoriesTags { get; set; }

        [JsonProperty("allergens_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AllergensTags { get; set; }

        [JsonProperty("brands", NullValueHandling = NullValueHandling.Ignore)]
        public string Brands { get; set; }

        [JsonProperty("nutrition_score_warning_no_fiber", NullValueHandling = NullValueHandling.Ignore)]
        public long? NutritionScoreWarningNoFiber { get; set; }

        [JsonProperty("nutrition_score_beverage", NullValueHandling = NullValueHandling.Ignore)]
        public long? NutritionScoreBeverage { get; set; }

        [JsonProperty("ingredients_analysis_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IngredientsAnalysisTags { get; set; }

        [JsonProperty("images", NullValueHandling = NullValueHandling.Ignore)]
        public Images Images { get; set; }

        [JsonProperty("states", NullValueHandling = NullValueHandling.Ignore)]
        public string States { get; set; }

        [JsonProperty("product_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductName { get; set; }

        [JsonProperty("ingredients_that_may_be_from_palm_oil_n", NullValueHandling = NullValueHandling.Ignore)]
        public long? IngredientsThatMayBeFromPalmOilN { get; set; }

        [JsonProperty("additives_debug_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AdditivesDebugTags { get; set; }

        [JsonProperty("producer_version_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProducerVersionId { get; set; }

        [JsonProperty("countries_lc", NullValueHandling = NullValueHandling.Ignore)]
        public string CountriesLc { get; set; }

        [JsonProperty("stores_debug_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> StoresDebugTags { get; set; }

        [JsonProperty("image_ingredients_small_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ImageIngredientsSmallUrl { get; set; }

        [JsonProperty("additives_prev_original_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AdditivesPrevOriginalTags { get; set; }

        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public string Categories { get; set; }

        [JsonProperty("last_modified_by", NullValueHandling = NullValueHandling.Ignore)]
        public string LastModifiedBy { get; set; }

        [JsonProperty("conservation_conditions", NullValueHandling = NullValueHandling.Ignore)]
        public string ConservationConditions { get; set; }

        [JsonProperty("last_editor", NullValueHandling = NullValueHandling.Ignore)]
        public string LastEditor { get; set; }

        [JsonProperty("interface_version_modified", NullValueHandling = NullValueHandling.Ignore)]
        public string InterfaceVersionModified { get; set; }

        [JsonProperty("ingredients", NullValueHandling = NullValueHandling.Ignore)]
        public List<Ingredient> Ingredients { get; set; }

        [JsonProperty("labels_prev_hierarchy", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LabelsPrevHierarchy { get; set; }

        [JsonProperty("misc_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MiscTags { get; set; }

        [JsonProperty("additives_old_n", NullValueHandling = NullValueHandling.Ignore)]
        public long? AdditivesOldN { get; set; }

        [JsonProperty("allergens_from_ingredients", NullValueHandling = NullValueHandling.Ignore)]
        public string AllergensFromIngredients { get; set; }

        [JsonProperty("selected_images", NullValueHandling = NullValueHandling.Ignore)]
        public SelectedImages SelectedImages { get; set; }

        [JsonProperty("states_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> StatesTags { get; set; }

        [JsonProperty("nutrition_data_prepared_per", NullValueHandling = NullValueHandling.Ignore)]
        public string NutritionDataPreparedPer { get; set; }

        [JsonProperty("editors_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EditorsTags { get; set; }

        [JsonProperty("traces", NullValueHandling = NullValueHandling.Ignore)]
        public string Traces { get; set; }

        [JsonProperty("manufacturing_places", NullValueHandling = NullValueHandling.Ignore)]
        public string ManufacturingPlaces { get; set; }

        [JsonProperty("emb_codes_debug_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> EmbCodesDebugTags { get; set; }

        [JsonProperty("ingredients_text_with_allergens_fr", NullValueHandling = NullValueHandling.Ignore)]
        public string IngredientsTextWithAllergensFr { get; set; }

        [JsonProperty("nutrient_levels_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NutrientLevelsTags { get; set; }

        [JsonProperty("traces_from_ingredients", NullValueHandling = NullValueHandling.Ignore)]
        public string TracesFromIngredients { get; set; }

        [JsonProperty("expiration_date_debug_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> ExpirationDateDebugTags { get; set; }

        [JsonProperty("serving_size_debug_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> ServingSizeDebugTags { get; set; }

        [JsonProperty("allergens_hierarchy", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AllergensHierarchy { get; set; }

        [JsonProperty("brands_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BrandsTags { get; set; }

        [JsonProperty("ingredients_debug", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IngredientsDebug { get; set; }

        [JsonProperty("countries_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CountriesTags { get; set; }

        [JsonProperty("countries", NullValueHandling = NullValueHandling.Ignore)]
        public string Countries { get; set; }

        [JsonProperty("generic_name_fr_debug_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> GenericNameFrDebugTags { get; set; }

        [JsonProperty("ingredients_from_palm_oil_n", NullValueHandling = NullValueHandling.Ignore)]
        public long? IngredientsFromPalmOilN { get; set; }

        [JsonProperty("sortkey", NullValueHandling = NullValueHandling.Ignore)]
        public long? Sortkey { get; set; }
    }

    public partial class Images
    {
        [JsonProperty("1", NullValueHandling = NullValueHandling.Ignore)]
        public The1 The1 { get; set; }

        [JsonProperty("2", NullValueHandling = NullValueHandling.Ignore)]
        public The1 The2 { get; set; }

        [JsonProperty("3", NullValueHandling = NullValueHandling.Ignore)]
        public The1 The3 { get; set; }

        [JsonProperty("4", NullValueHandling = NullValueHandling.Ignore)]
        public The1 The4 { get; set; }

        [JsonProperty("5", NullValueHandling = NullValueHandling.Ignore)]
        public The1 The5 { get; set; }

        [JsonProperty("ingredients_fr", NullValueHandling = NullValueHandling.Ignore)]
        public Fr IngredientsFr { get; set; }

        [JsonProperty("nutrition_fr", NullValueHandling = NullValueHandling.Ignore)]
        public Fr NutritionFr { get; set; }

        [JsonProperty("front_fr", NullValueHandling = NullValueHandling.Ignore)]
        public Fr FrontFr { get; set; }
    }

    public partial class Fr
    {
        [JsonProperty("geometry", NullValueHandling = NullValueHandling.Ignore)]
        public string Geometry { get; set; }

        [JsonProperty("rev", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Rev { get; set; }

        [JsonProperty("angle", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Angle { get; set; }

        [JsonProperty("x2", NullValueHandling = NullValueHandling.Ignore)]
        public string X2 { get; set; }

        [JsonProperty("y2", NullValueHandling = NullValueHandling.Ignore)]
        public string Y2 { get; set; }

        [JsonProperty("imgid", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Imgid { get; set; }

        [JsonProperty("white_magic", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? WhiteMagic { get; set; }

        [JsonProperty("x1", NullValueHandling = NullValueHandling.Ignore)]
        public string X1 { get; set; }

        [JsonProperty("normalize", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Normalize { get; set; }

        [JsonProperty("y1", NullValueHandling = NullValueHandling.Ignore)]
        public string Y1 { get; set; }

        [JsonProperty("sizes", NullValueHandling = NullValueHandling.Ignore)]
        public Sizes Sizes { get; set; }
    }

    public partial class Sizes
    {
        [JsonProperty("100", NullValueHandling = NullValueHandling.Ignore)]
        public The100 The100 { get; set; }

        [JsonProperty("400", NullValueHandling = NullValueHandling.Ignore)]
        public The100 The400 { get; set; }

        [JsonProperty("full", NullValueHandling = NullValueHandling.Ignore)]
        public The100 Full { get; set; }

        [JsonProperty("200", NullValueHandling = NullValueHandling.Ignore)]
        public The100 The200 { get; set; }
    }

    public partial class The100
    {
        [JsonProperty("w", NullValueHandling = NullValueHandling.Ignore)]
        public long? W { get; set; }

        [JsonProperty("h", NullValueHandling = NullValueHandling.Ignore)]
        public long? H { get; set; }
    }

    public partial class The1
    {
        [JsonProperty("uploader", NullValueHandling = NullValueHandling.Ignore)]
        public string Uploader { get; set; }

        [JsonProperty("sizes", NullValueHandling = NullValueHandling.Ignore)]
        public Sizes Sizes { get; set; }

        [JsonProperty("uploaded_t", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? UploadedT { get; set; }
    }

    public partial class Ingredient
    {
        [JsonProperty("percent", NullValueHandling = NullValueHandling.Ignore)]
        public string Percent { get; set; }

        [JsonProperty("rank", NullValueHandling = NullValueHandling.Ignore)]
        public long? Rank { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        [JsonProperty("vegetarian", NullValueHandling = NullValueHandling.Ignore)]
        public FromPalmOil? Vegetarian { get; set; }

        [JsonProperty("vegan", NullValueHandling = NullValueHandling.Ignore)]
        public FromPalmOil? Vegan { get; set; }

        [JsonProperty("from_palm_oil", NullValueHandling = NullValueHandling.Ignore)]
        public FromPalmOil? FromPalmOil { get; set; }

        [JsonProperty("origin", NullValueHandling = NullValueHandling.Ignore)]
        public string Origin { get; set; }
    }

    public partial class Languages
    {
        [JsonProperty("en:french", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnFrench { get; set; }
    }

    public partial class LanguagesCodes
    {
        [JsonProperty("fr", NullValueHandling = NullValueHandling.Ignore)]
        public long? Fr { get; set; }
    }

    public partial class NutrientLevels
    {
        [JsonProperty("salt", NullValueHandling = NullValueHandling.Ignore)]
        public string Salt { get; set; }

        [JsonProperty("sugars", NullValueHandling = NullValueHandling.Ignore)]
        public string Sugars { get; set; }

        [JsonProperty("saturated-fat", NullValueHandling = NullValueHandling.Ignore)]
        public string SaturatedFat { get; set; }

        [JsonProperty("fat", NullValueHandling = NullValueHandling.Ignore)]
        public string Fat { get; set; }
    }

    public partial class Nutriments
    {
        [JsonProperty("saturated-fat_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string SaturatedFatUnit { get; set; }

        [JsonProperty("nutrition-score-fr-producer_serving", NullValueHandling = NullValueHandling.Ignore)]
        public long? NutritionScoreFrProducerServing { get; set; }

        [JsonProperty("nutrition-score-fr", NullValueHandling = NullValueHandling.Ignore)]
        public long? NutritionScoreFr { get; set; }

        [JsonProperty("energy_100g", NullValueHandling = NullValueHandling.Ignore)]
        public long? Energy100G { get; set; }

        [JsonProperty("nutrition-score-fr-producer_value", NullValueHandling = NullValueHandling.Ignore)]
        public long? NutritionScoreFrProducerValue { get; set; }

        [JsonProperty("nutrition-score-fr_serving", NullValueHandling = NullValueHandling.Ignore)]
        public long? NutritionScoreFrServing { get; set; }

        [JsonProperty("sugars_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string SugarsUnit { get; set; }

        [JsonProperty("sodium_100g", NullValueHandling = NullValueHandling.Ignore)]
        public double? Sodium100G { get; set; }

        [JsonProperty("carbon-footprint-from-known-ingredients_product", NullValueHandling = NullValueHandling.Ignore)]
        public long? CarbonFootprintFromKnownIngredientsProduct { get; set; }

        [JsonProperty("nutrition-score-uk", NullValueHandling = NullValueHandling.Ignore)]
        public long? NutritionScoreUk { get; set; }

        [JsonProperty("sugars_serving", NullValueHandling = NullValueHandling.Ignore)]
        public double? SugarsServing { get; set; }

        [JsonProperty("carbohydrates", NullValueHandling = NullValueHandling.Ignore)]
        public long? Carbohydrates { get; set; }

        [JsonProperty("nutrition-score-uk_100g", NullValueHandling = NullValueHandling.Ignore)]
        public long? NutritionScoreUk100G { get; set; }

        [JsonProperty("salt_serving", NullValueHandling = NullValueHandling.Ignore)]
        public double? SaltServing { get; set; }

        [JsonProperty("sugars", NullValueHandling = NullValueHandling.Ignore)]
        public double? Sugars { get; set; }

        [JsonProperty("sugars_100g", NullValueHandling = NullValueHandling.Ignore)]
        public double? Sugars100G { get; set; }

        [JsonProperty("energy_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string EnergyUnit { get; set; }

        [JsonProperty("fat_value", NullValueHandling = NullValueHandling.Ignore)]
        public long? FatValue { get; set; }

        [JsonProperty("energy", NullValueHandling = NullValueHandling.Ignore)]
        public long? Energy { get; set; }

        [JsonProperty("salt_value", NullValueHandling = NullValueHandling.Ignore)]
        public double? SaltValue { get; set; }

        [JsonProperty("nova-group", NullValueHandling = NullValueHandling.Ignore)]
        public long? NovaGroup { get; set; }

        [JsonProperty("saturated-fat", NullValueHandling = NullValueHandling.Ignore)]
        public double? SaturatedFat { get; set; }

        [JsonProperty("nova-group_serving", NullValueHandling = NullValueHandling.Ignore)]
        public long? NovaGroupServing { get; set; }

        [JsonProperty("carbon-footprint-from-known-ingredients_100g", NullValueHandling = NullValueHandling.Ignore)]
        public double? CarbonFootprintFromKnownIngredients100G { get; set; }

        [JsonProperty("carbohydrates_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string CarbohydratesUnit { get; set; }

        [JsonProperty("sugars_value", NullValueHandling = NullValueHandling.Ignore)]
        public double? SugarsValue { get; set; }

        [JsonProperty("nutrition-score-fr_100g", NullValueHandling = NullValueHandling.Ignore)]
        public long? NutritionScoreFr100G { get; set; }

        [JsonProperty("carbohydrates_serving", NullValueHandling = NullValueHandling.Ignore)]
        public long? CarbohydratesServing { get; set; }

        [JsonProperty("proteins_100g", NullValueHandling = NullValueHandling.Ignore)]
        public double? Proteins100G { get; set; }

        [JsonProperty("nutrition-score-fr-producer_100g", NullValueHandling = NullValueHandling.Ignore)]
        public double? NutritionScoreFrProducer100G { get; set; }

        [JsonProperty("nova-group_100g", NullValueHandling = NullValueHandling.Ignore)]
        public long? NovaGroup100G { get; set; }

        [JsonProperty("sodium_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string SodiumUnit { get; set; }

        [JsonProperty("nutrition-score-fr-producer", NullValueHandling = NullValueHandling.Ignore)]
        public long? NutritionScoreFrProducer { get; set; }

        [JsonProperty("carbohydrates_100g", NullValueHandling = NullValueHandling.Ignore)]
        public double? Carbohydrates100G { get; set; }

        [JsonProperty("fat_serving", NullValueHandling = NullValueHandling.Ignore)]
        public long? FatServing { get; set; }

        [JsonProperty("salt", NullValueHandling = NullValueHandling.Ignore)]
        public double? Salt { get; set; }

        [JsonProperty("sodium_serving", NullValueHandling = NullValueHandling.Ignore)]
        public double? SodiumServing { get; set; }

        [JsonProperty("proteins_serving", NullValueHandling = NullValueHandling.Ignore)]
        public long? ProteinsServing { get; set; }

        [JsonProperty("saturated-fat_100g", NullValueHandling = NullValueHandling.Ignore)]
        public double? SaturatedFat100G { get; set; }

        [JsonProperty("saturated-fat_serving", NullValueHandling = NullValueHandling.Ignore)]
        public double? SaturatedFatServing { get; set; }

        [JsonProperty("carbohydrates_value", NullValueHandling = NullValueHandling.Ignore)]
        public long? CarbohydratesValue { get; set; }

        [JsonProperty("nutrition-score-fr-producer_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string NutritionScoreFrProducerUnit { get; set; }

        [JsonProperty("proteins", NullValueHandling = NullValueHandling.Ignore)]
        public long? Proteins { get; set; }

        [JsonProperty("salt_100g", NullValueHandling = NullValueHandling.Ignore)]
        public double? Salt100G { get; set; }

        [JsonProperty("nutrition-score-uk_serving", NullValueHandling = NullValueHandling.Ignore)]
        public long? NutritionScoreUkServing { get; set; }

        [JsonProperty("proteins_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string ProteinsUnit { get; set; }

        [JsonProperty("sodium_value", NullValueHandling = NullValueHandling.Ignore)]
        public double? SodiumValue { get; set; }

        [JsonProperty("saturated-fat_value", NullValueHandling = NullValueHandling.Ignore)]
        public double? SaturatedFatValue { get; set; }

        [JsonProperty("fat", NullValueHandling = NullValueHandling.Ignore)]
        public long? Fat { get; set; }

        [JsonProperty("salt_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string SaltUnit { get; set; }

        [JsonProperty("fat_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string FatUnit { get; set; }

        [JsonProperty("proteins_value", NullValueHandling = NullValueHandling.Ignore)]
        public long? ProteinsValue { get; set; }

        [JsonProperty("fat_100g", NullValueHandling = NullValueHandling.Ignore)]
        public double? Fat100G { get; set; }

        [JsonProperty("sodium", NullValueHandling = NullValueHandling.Ignore)]
        public double? Sodium { get; set; }

        [JsonProperty("energy_serving", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnergyServing { get; set; }

        [JsonProperty("carbon-footprint-from-known-ingredients_serving", NullValueHandling = NullValueHandling.Ignore)]
        public long? CarbonFootprintFromKnownIngredientsServing { get; set; }

        [JsonProperty("energy_value", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnergyValue { get; set; }
    }

    public partial class SelectedImages
    {
        [JsonProperty("front", NullValueHandling = NullValueHandling.Ignore)]
        public Front Front { get; set; }

        [JsonProperty("nutrition", NullValueHandling = NullValueHandling.Ignore)]
        public Front Nutrition { get; set; }

        [JsonProperty("ingredients", NullValueHandling = NullValueHandling.Ignore)]
        public Front Ingredients { get; set; }
    }

    public partial class Front
    {
        [JsonProperty("display", NullValueHandling = NullValueHandling.Ignore)]
        public Display Display { get; set; }

        [JsonProperty("thumb", NullValueHandling = NullValueHandling.Ignore)]
        public Display Thumb { get; set; }

        [JsonProperty("small", NullValueHandling = NullValueHandling.Ignore)]
        public Display Small { get; set; }
    }

    public partial class Display
    {
        [JsonProperty("fr", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Fr { get; set; }
    }

    public partial class Source
    {
        [JsonProperty("import_t", NullValueHandling = NullValueHandling.Ignore)]
        public long? ImportT { get; set; }

        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Fields { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("manufacturer", NullValueHandling = NullValueHandling.Ignore)]
        public long? Manufacturer { get; set; }

        [JsonProperty("images", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Images { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }
    }

    public enum FromPalmOil { Maybe, No, Yes };

    public partial class ProductDataClass
    {
        public static ProductDataClass FromJson(string json) => JsonConvert.DeserializeObject<ProductDataClass>(json, OpenFoodFactsAPIData.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this ProductDataClass self) => JsonConvert.SerializeObject(self, OpenFoodFactsAPIData.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                FromPalmOilConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class PurpleParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly PurpleParseStringConverter Singleton = new PurpleParseStringConverter();
    }

    internal class FluffyParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(bool) || t == typeof(bool?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            bool b;
            if (Boolean.TryParse(value, out b))
            {
                return b;
            }
            throw new Exception("Cannot unmarshal type bool");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (bool)untypedValue;
            var boolString = value ? "true" : "false";
            serializer.Serialize(writer, boolString);
            return;
        }

        public static readonly FluffyParseStringConverter Singleton = new FluffyParseStringConverter();
    }

    internal class FromPalmOilConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FromPalmOil) || t == typeof(FromPalmOil?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "maybe":
                    return FromPalmOil.Maybe;
                case "no":
                    return FromPalmOil.No;
                case "yes":
                    return FromPalmOil.Yes;
            }
            throw new Exception("Cannot unmarshal type FromPalmOil");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (FromPalmOil)untypedValue;
            switch (value)
            {
                case FromPalmOil.Maybe:
                    serializer.Serialize(writer, "maybe");
                    return;
                case FromPalmOil.No:
                    serializer.Serialize(writer, "no");
                    return;
                case FromPalmOil.Yes:
                    serializer.Serialize(writer, "yes");
                    return;
            }
            throw new Exception("Cannot marshal type FromPalmOil");
        }

        public static readonly FromPalmOilConverter Singleton = new FromPalmOilConverter();
    }
}
