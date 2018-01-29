using JetBrains.Annotations;
// ReSharper disable UnusedMember.Global

namespace Core2.Selkie.Services.Common.Dto
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