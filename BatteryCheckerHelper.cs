using static paradigm_shift_csharp.DisplayMessages;

namespace paradigm_shift_csharp
{
    internal static class BatteryCheckerHelper
    {
        private static readonly float _minTemperature = 0;
        private static readonly float _maxTemperature = 45;
        private static readonly float _minSoc = 20;
        private static readonly float _maxSoc = 80;
        private static readonly float _minCharge = 0.1F;
        private static readonly float _maxCharge = 0.8F;

        public static bool BatteryIsOk(float temperature, float stateOfCharge, float chargeRate)
        {
            bool temperatureOk = CheckParameterOk(temperature, _minTemperature, _maxTemperature, "temperature");
            bool socOk = CheckParameterOk(stateOfCharge, _minSoc, _maxSoc, "charge state");
            bool chargeRateOk = CheckParameterOk(chargeRate, _minCharge, _maxCharge, "charge rate");
            return temperatureOk && socOk && chargeRateOk;
        }

        private static bool CheckParameterOk(float parameterValue, float minValue, float maxValue, string parameterName)
        {
            if (IsValueInRange(parameterValue, minValue, maxValue))
            {
                PrintOkMessage(parameterName, LanguageOption.English);
                return true;
            }
            
            if (IsValueInToleranceRange(parameterValue, minValue, maxValue))
            {
                PrintWarnMessage(parameterName, LanguageOption.English);
                return true;
            }
            else
            {
                PrintErrorMessage(parameterName, LanguageOption.English);
                return false;
            }
        }

        private static bool IsValueInRange(float value, float minValue, float maxValue)
        {
            return value >= minValue && value <= maxValue;
        }

        private static bool IsValueInToleranceRange(float value, float minValue, float maxValue)
        {
            float tolerance = (maxValue - minValue) * 0.05f;
            return value >= (maxValue - tolerance) && value <= (minValue + tolerance);
        }
    }
}
