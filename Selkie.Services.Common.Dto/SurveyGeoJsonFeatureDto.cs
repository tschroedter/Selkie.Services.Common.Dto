using JetBrains.Annotations;

namespace Selkie.Services.Common.Dto
{
    [UsedImplicitly]
    public class SurveyGeoJsonFeatureDto
    {
        [NotNull]
        public string SurveyFeatureAsGeoJson = string.Empty;

        [NotNull]
        public SurveyFeatureDto SurveyFeatureDto = new SurveyFeatureDto();
    }
}