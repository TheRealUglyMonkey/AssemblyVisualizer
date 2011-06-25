﻿// Copyright 2011 Denis Markelov
// Adopted, originally created as part of WPFExtensions library
// This code is distributed under Apache 2.0 license 
// (for details please see \docs\LICENSE, \docs\NOTICE)

using System;
using System.Globalization;
using System.Windows.Data;

namespace ILSpyVisualizer.Controls.ZoomControl.Converters
{
    public class EqualityToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return object.Equals(value, parameter);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
                return parameter;

            //it's false, so don't bind it back
            throw new Exception("EqualityToBooleanConverter: It's false, I won't bind back.");
        }
    }
}