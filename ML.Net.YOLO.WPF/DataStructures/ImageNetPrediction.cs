using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.ML.Data;

namespace ML.Net.YOLO.WPF.DataStructures
{
    public class ImageNetPrediction
    {
        [ColumnName("grid")]
        public float[] PredictedLabels;
    }
}