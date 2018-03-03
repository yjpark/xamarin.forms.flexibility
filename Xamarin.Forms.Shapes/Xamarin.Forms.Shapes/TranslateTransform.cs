﻿namespace Xamarin.Forms.Media
{
    public class TranslateTransform : Transform
    {
        public static readonly BindableProperty XProperty =
            BindableProperty.Create("X",
                                    typeof(double),
                                    typeof(TranslateTransform),
                                    0.0,
                                    propertyChanged: OnTransformPropertyChanged);

        public static readonly BindableProperty YProperty =
            BindableProperty.Create("Y",
                                    typeof(double),
                                    typeof(TranslateTransform),
                                    0.0,
                                    propertyChanged: OnTransformPropertyChanged);

        public double X
        {
            set { SetValue(XProperty, value); }
            get { return (double)GetValue(XProperty); }
        }

        public double Y
        {
            set { SetValue(YProperty, value); }
            get { return (double)GetValue(YProperty); }
        }

        static void OnTransformPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            (bindable as TranslateTransform).OnTransformPropertyChanged();
        }

        void OnTransformPropertyChanged()
        {
            Value = new Matrix(1, 0, 0, 1, X, Y);
        }
    }
}