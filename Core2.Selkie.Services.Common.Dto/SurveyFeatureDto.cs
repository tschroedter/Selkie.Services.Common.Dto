using JetBrains.Annotations;
// ReSharper disable UnusedMember.Global

namespace Core2.Selkie.Services.Common.Dto
{
    [UsedImplicitly]
    public class SurveyFeatureDto
    {
        public double AngleToXAxisAtEndPoint;

        public double AngleToXAxisAtStartPoint;

        [NotNull]
        public PointDto EndPoint = new PointDto();

        public int Id;
        public bool IsUnknown;

        public double Length;

        [NotNull]
        public string RunDirection = string.Empty;

        [NotNull]
        public PointDto StartPoint = new PointDto();
    }
}