   M S B A M L   `   `   `  ����B  >Jupiter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Jupiter.ViewsJupiter.Views  5          Jupiter.Views.AppMain   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Jupiter.Views     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      -   5          �Name$  window��5	       � Title$ JÚPITER��5
      $
��1000��5      $	��580��5       � AllowsTransparency .  � Icon$! /Jupiter;component/logo.ico��5       � Language$ pt-PT�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      ��5      Z�  � 	Resources 5         Iniciar �� 
TargetName	 �� TargetProperty9  3System.Windows.Media.Animation.EasingDoubleKeyFrame
 O� KeyTime O� Value   EasingFunction-  'System.Windows.Media.Animation.BackEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode0  *System.Windows.Media.Animation.QuarticEase  Sair��%�  &	        &	 Z    �� 5   
   .��5      U� $
 card��6,   $V	 P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6I   .\�5        $
 0��6'   $ 0Q�63    5        5      $ EaseOut=�6#   5        5      $
 0:0:0.5��6'   $	 0.6Q�69     5      $
 0:0:0.8��6'   $	 0.5Q�69     5      $
 0:0:1��6'   $ 1Q�67    5         5!      $ EaseOut=�6#   5#      5$      U� 5%      $
 card��6,   $V	 P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6I   .\�5&        $
 0��6'   $ 0Q�63    5'        5(      $ EaseOut=�6#   5*        5+      $
 0:0:0.5��6'   $	 0.6Q�69     5,      $
 0:0:0.8��6'   $	 0.5Q�69     5-      $
 0:0:1��6'   $ 1Q�67    5.        5/      $ EaseOut=�6#   51      52      U� 53      $
 card��6,   $V	 P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6I   .\�54        $
 0��6'   $ 0Q�63    55        56      $ EaseIn=�6&   58        59      $
 0:0:0.5��6'   $ 0Q�69     5:      $
 0:0:0.8��6'   $ 0Q�69     5;      $
 0:0:1��6'   $ 0Q�67    5<        5=      $ EaseIn=�6&   5?      5@      U� 5A      $
 card��6,   $U	 O(UIElement.RenderTransform).(TransformGroup.Children)[1].(SkewTransform.AngleX)�6I   .\�5B        $
 0��6'   $ 0Q�63    5C        5D      $ 	EaseInOut=�6&   5F        5G      $
 0:0:0.5��6'   $ 0Q�69     5H      $
 0:0:0.8��6'   $ 0Q�69     5I      $
 0:0:1��6'   $ 0Q�67    5J        5K      $ 	EaseInOut=�6&   5M      5N      U� 5O      $
 card��6,   $U	 O(UIElement.RenderTransform).(TransformGroup.Children)[1].(SkewTransform.AngleY)�6I   .\�5P        $
 0��6'   $ 0Q�63    5Q        5R      $ 	EaseInOut=�6&   5T        5U      $
 0:0:0.5��6'   $ 0Q�69     5V      $
 0:0:0.8��6'   $ 0Q�69     5W      $
 0:0:1��6'   $ 0Q�67    5X        5Y      $ 	EaseInOut=�6&   5[      5\      5]      �� 5^   
   .��5_      U� $
 card��6,   $V	 P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6I   .\�5`      �� $
 0��6'   $ 1Q�63   �� 5a      $
 0:0:0.2��6'   $	 0.5Q�69   �� 5b      $
 0:0:0.5��6'   $	 0.6Q�69   �� 5c      $
 0:0:1��6'   $ 0Q�67   5d      U� 5e      $
 card��6,   $V	 P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6I   .\�5f      �� $
 0��6'   $ 1Q�63   �� 5g      $
 0:0:0.2��6'   $	 0.5Q�69   �� 5h      $
 0:0:0.5��6'   $	 0.6Q�69   �� 5i      $
 0:0:1��6'   $ 0Q�67   5j      U� 5k      $
 card��6,   $V	 P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6I   .\�5l      �� $
 0��6'   $ 0Q�63   �� 5m      $
 0:0:0.2��6'   $ 0Q�69   �� 5n      $
 0:0:0.5��6'   $ 0Q�69   �� 5o      $
 0:0:1��6'   $ 0Q�67   5p      U� 5q      $
 card��6,   $U	 O(UIElement.RenderTransform).(TransformGroup.Children)[1].(SkewTransform.AngleX)�6I   .\�5r      �� $
 0��6'   $ 0Q�63   �� 5s      $
 0:0:0.2��6'   $ 0Q�69   �� 5t      $
 0:0:0.5��6'   $ 0Q�69   �� 5u      $
 0:0:1��6'   $ 0Q�67   5v      U� 5w      $
 card��6,   $U	 O(UIElement.RenderTransform).(TransformGroup.Children)[1].(SkewTransform.AngleY)�6I   .\�5x      �� $
 0��6'   $ 0Q�63   �� 5y      $
 0:0:0.2��6'   $ 0Q�69   �� 5z      $
 0:0:0.5��6'   $ 0Q�69   �� 5{      $
 0:0:1��6'   $ 0Q�67   5|      5}      5~       � Triggers 5      :� 5�   
    :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5�      �� #��[  6   5�      :� 5�   
   $ ButtonBase.Click��6    :� 
SourceName$ 	btn_close��66   .[�5�      �� -   5         ��Name$ Sair_BeginStoryboard��5�      #��[ 6<   5�      .��5�      #  MaterialDesignThemes.Wpf.Card  -   5          Name$
 card��5�   	   $��Stretch=�5�   	   $��Stretch=�5�   	    J� RenderTransformOrigin$ 0.5,0.5&�5�   	      UniformCornerRadius$ 4Q�5�   	   z�5�   
   V� 5�      .~�5�      �� �� 5�      �� 5�      T� 5�      5�      .��5�   
   �  � RowDefinitions 5�      �� 5�      $��50 �6    �� 5�      $��* �6     � ColumnDefinitions 5�      �� 5�      $	��150 �6#   �� 5�      $��* �6#   .+�5�      �� -   5        $��_Tema��5�      ���	#FF141414
�������$y�	Collapsed=�5�      (  "MaterialDesignThemes.Wpf.ColorZone  5�      -   5        $��0��5�      $��1��5�      $��Stretch=�5�      $��Stretch=�5�      
����������	#FFE0E0E0$��0,0,0,1q�5�      .��5�      � .+�5�      �� $
��20,5q�5�      $
��Left=�5�      $	��Top=�5�      .+�5�      ��  �� Orientation$ 
Horizontal=�6%   .+�5�      �� $��16(�6(   JP5�      5�      �� 5�      $	��Top=�6%   $ 
Horizontal=�6=   .+�5�      �� $��12(�6(   
�������Bem Vindo ao5�      �� 5�      $��5,0,0,0q�5�   !   $��Center=�5�   !   $��12(�5�   !   
Júpiter5�      5�      5�      �� 5�      $
��20,5q�5�      $��Right=�5�      $��Center=�5�      $ 
Horizontal=�5�      .+�5�      �� -   5        $��btn_mi��5�      $��40��5�      $��4q�5�      ��5�      Z� ��5�      Z� .��5�      '  !MaterialDesignThemes.Wpf.PackIcon  $��14��5�   !   $��14��5�   !   �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ WindowMinimize=�5�   !   5�      �� 5�      -   5        $��btn_max��5�      $��40��5�      $	��4,0q�5�      $��4q�5�      ��5�      Z� ��5�      Z� .��5�        $��14��5�   !   $��14��5�   !   $ WindowMaximize=�5�   !   5�      �� 5�      -   5        $��	btn_close��5�      $��40��5�      $��4q�5�      
���   ����	#DDFFFFFF��5�      Z� .��5�        $��14��5�   !   $��14��5�   !   $ WindowClose=�5�   !   5�      5�      5�      5�        5�      -	   5        $��2��5�      $��Stretch=�5�      $��Stretch=�5�      ��5�      ��  �� ElementName$ _Tema�� �� Path$ 
Background���5�      �� $ _Tema��$ 
Foreground�.��5�      � .+�5�      �� $��Stretch=�6!   $��Stretch=�6?   .+�5�      �� $
��0,20q�5�      $��Center=�5�      $ 
Horizontal=�5�      .+�5        $��30��5  !   $��30��5  !   $��Center=�5  !   $ School=�5  !   ��5  !   �� $ _Tema��$ 
Foreground�5  !   �� 5     $
��10,0q�5  !   $��Center=�5  !   $��Center=�5	  !   $��Segoe WP Light)�5
  !   $��20(�5  !   $
��Bold"�5  !   ��5  !   �� $ _Tema��$ 
Foreground�
Júpiter5     5     �� 5     ��6$   �� $ _Tema��$ 
Background��� 5     -
   5        $��	btn_START��5     $	��150��5     $��0,4,0,0q�5     $
��Left=�5     $
��Left=�5     $��0,0,2,0q�5     $��Segoe WP Light)�5     ��5     Z� ��5     Z� .��5     �� $ 
Horizontal=�6)   .+�5  "     $
��Left=�5  %   $��Center=�5   %   $
 home=�5"  %   ��5!  %   �� $ _Tema��$ 
Foreground�5"  %   �� 5#  "   $
��10,0q�5$  %   $
��Left=�5%  %   $��Center=�5&  %   $��Yu Gothic UI Light)�5'  %   $��12(�5(  %   ��5)  %   �� $ _Tema��$ 
Foreground�	Principal5+  #   5,     5-     �� 5/     -   5        $��btn_prin��50     $	��150��51     $��0,4,0,0q�52     $
��Left=�53     $
��Left=�54     $��0,0,2,0q�57     $��Segoe WP Light)�59     ��55     Z� ��56     Z� .��5:     �� $ 
Horizontal=�6)   .+�5;  "     $
��Left=�5<  %   $��Center=�5=  %   $ AppleKeyboardCommand=�5?  %   ��5>  %   �� $ _Tema��$ 
Foreground�5?  %   �� 5@  "   $
��10,0q�5A  %   $
��Left=�5B  %   $��Center=�5C  %   $��Segoe UI Symbol)�5D  %   $��12(�5E  %   ��5F  %   �� $ _Tema��$ 
Foreground�Ária de trabalho5H  #   5I     5J     �� 5L     -   5        $��_btn_Alunos��5M     $	��150��5N     $��0,4,0,0q�5O     $
��Left=�5P     $
��Left=�5Q     $��0,0,2,0q�5T     $��Segoe WP Light)�5U     ��5R     Z� ��5S     Z� .��5V     �� $ 
Horizontal=�6)   .+�5W  "     $
��Left=�5X  %   $��Center=�5Y  %   $ Users=�5[  %   ��5Z  %   �� $ _Tema��$ 
Foreground�5[  %   �� 5\  "   $
��10,0q�5]  %   $
��Left=�5^  %   $��Center=�5_  %   $��Yu Gothic UI Light)�5`  %   $��12(�5a  %   ��5b  %   �� $ _Tema��$ 
Foreground�Alunos5d  #   5e     5f     �� 5i     -   5        $��_btn_historico��5j     $	��150��5k     $��0,4,0,0q�5l     $��16,0,0,0q�5m     $
��Left=�5n     $
��Left=�5o     $��0,0,2,0q�5r     $��Segoe WP Light)�5s     ��5p     Z� ��5q     Z� .��5t     �� $ 
Horizontal=�6)   .+�5u  "     $
��Left=�5v  %   $��Center=�5w  %   $ History=�5y  %   ��5x  %   �� $ _Tema��$ 
Foreground�5y  %   �� 5z  "   $
��10,0q�5{  %   $
��Left=�5|  %   $��Center=�5}  %   $��Yu Gothic UI Light)�5~  %   $��12(�5  %   ��5�  %   �� $ _Tema��$ 
Foreground�
Histórico5�  #   5�     5�     �� 5�     -   5        $��btn_Vpagamentos��5�     $	��150��5�     $��0,4,0,0q�5�     $��16,0,0,0q�5�     $
��Left=�5�     $
��Left=�5�     $��0,0,2,0q�5�     $��Yu Gothic UI Light)�5�     ��5�     Z� ��5�     Z� .��5�     �� $ 
Horizontal=�6)   .+�5�  "     $
��Left=�5�  %   $��Center=�5�  %   $ Calendar=�5�  %   ��5�  %   �� $ _Tema��$ 
Foreground�5�  %   �� 5�  "   $
��10,0q�5�  %   $
��Left=�5�  %   $��Center=�5�  %   $��Yu Gothic UI Light)�5�  %   $��12(�5�  %   ��5�  %   �� $ _Tema��$ 
Foreground�	Pagamento5�  #   5�     5�     �� 5�     -   5        $��btn_settings��5�     $	��150��5�     $��0,4,0,0q�5�     $��16,0,0,0q�5�     $
��Left=�5�     $
��Left=�5�     $��0,0,2,0q�5�     $��Yu Gothic UI Light)�5�     ��5�     Z� ��5�     Z� .��5�     �� $ 
Horizontal=�6)   .+�5�  "     $
��Left=�5�  %   $��Center=�5�  %   $ SettingsOutline=�5�  %   ��5�  %   �� $ _Tema��$ 
Foreground�5�  %   �� 5�  "   $
��10,0q�5�  %   $
��Left=�5�  %   $��Center=�5�  %   $��Yu Gothic UI Light)�5�  %   $��12(�5�  %   ��5�  %   �� $ _Tema��$ 
Foreground�Definições5�  #   5�     5�     5�     5�     5�      � 5�     -   5        $��Views��5�     $��1��5�     $��1��5�     $��Stretch=�5�     $��Stretch=�5�       � NavigationUIVisibility$ Hidden=�5�     � 5�     -   5        $
��hide��5�     $��1��5�     $��1��5�     $��Stretch=�5�     $��Stretch=�5�     
���   � J� Opacity$	 0.5Q�5�     $y�Visible=�5�     .+�5�     �� $��Center=�6   $��Center=�6:   .+�5�     � $��50��5�     $��50��5�     ���	#FF00FFF3���	#FF00E2FF � IsIndeterminate .  % !MaterialDesignCircularProgressBar#��[ 5�      � Value$ 0Q�5�     �� 5�     $
��0,10q�6    
�������
Carregando5�     5�     5�     5�     5�     5�     