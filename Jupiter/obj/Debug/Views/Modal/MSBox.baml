   M S B A M L   `   `   `  ����B  >Jupiter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Jupiter.Views.ModalJupiter.Views.Modal  5          Jupiter.Views.Modal.MSBox   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Jupiter.Views.Modal     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      $	��500��5	      $	��350��5
        � AllowsTransparency  .    MaterialDesignFont#���   5       � Language$ pt-PT�5      $��13(�5      $��Regular"�5        MaterialDesignBody#���  5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      ��5      Z�  � 	Resources 5        Storyboard1 �� 
TargetName �� TargetProperty9  3System.Windows.Media.Animation.EasingDoubleKeyFrame	 O� KeyTime
 O� Value   EasingFunction0  *System.Windows.Media.Animation.QuarticEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode  sair0  *System.Windows.Media.Animation.QuinticEase��%p  &	       &	 �    �� 5   
   .��5      U� $
 card��6,   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6I   .\�5        $	 0��6'   $
 0Q�63    5        5      $ EaseOut=�6&   5        5      $	 0:0:0.5��6'   $
 1Q�69    5         5!      $ EaseOut=�6&   5#      5$      U� 5%      $
 card��6,   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6I   .\�5&        $	 0��6'   $
 0Q�63    5'        5(      $ EaseOut=�6&   5*        5+      $	 0:0:0.5��6'   $
 1Q�69    5,        5-      $ EaseOut=�6&   5/      50      51      �� 52   
   .��53      U� $
 card��6,   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6I   .\�54        $	 0��6'   $
 1Q�63    55        56      $ EaseOut=�6&   58        59      $	 0:0:0.5��6'   $
 0Q�69    5:        5;      $ EaseOut=�6&   5=      5>      U� 5?      $
 card��6,   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6I   .\�5@        $	 0��6'   $
 1Q�63    5A        5B      $ EaseOut=�6&   5D        5E      $	 0:0:0.5��6'   $
 0Q�69    5F        5G      $ EaseOut=�6&   5I      5J      5K      5L       � Triggers 5M      :� 5N   
    :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5O      �� #��[ 6   5P      :� 5Q   
   $ ButtonBase.Click��6    :� 
SourceName$ 	btn_close��66   .[�5R      �� -   5         ��Name$ sair_BeginStoryboard��5R      #��[ 6<   5S      .��5U      #  MaterialDesignThemes.Wpf.Card  -   5          Name$
 card��5V   	   $��Stretch=�5W   	    J� RenderTransformOrigin$ 0.5,0.5&�5X   	      UniformCornerRadius$ 4Q�5Y   	   z�5Z   
   V� 5[      .~�5\      �� �� 5]      �� 5^      T� 5_      5`      .��5b   
   �  � RowDefinitions 5c      �� 5d      $	��18* �6    �� 5e      $
��157* �6    .+�5g        -   5        $��Stretch=�5h      
���   �.��5k      � .+�5l      �� -   5        $��_TituloStatos��5m      $��Center=�5n      $��Center=�5o      $��16(�5p      ���	#DDFFFFFF$��Mensagem��5r      �� 5s      -   5        $��	btn_close��5t      $��Right=�5u      ���	#DDFFFFFF��5v      Z� ��5w      Z� .��5z      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ Close=�62   5{      5|      5}      � 5      $��1��6   .+�5�      �� $��Center=�6   $��Center=�6:   .+�5�        -   5        $��_Icon��5�      $��70��5�      $��70��5�      $��Center=�5�      $ MessageAlert=�5�      �� 5�      -   5        $��_Titulo��5�      $	��0,5q�5�      $��Center=�5�      $��14(�5�      $
��Bold"�5�       �� TextAlignment$ Center=�5�      Titulo do MSBox5�      �� 5�      -   5        $	��_MS��5�      $	��300��5�      $	��0,5q�5�      $��Center=�5�      $��Yu Gothic UI Semibold)�5�      $��12(�5�      $ Center=�5�      $
��Wrap=�5�      Mensagem do MSBox5�      �� 5�      -	   5        $	��_OK��5�      $	��0,5q�5�      $��Center=�5�       �� Orientation$ 
Horizontal=�5�      $y�	Collapsed=�5�      .+�5�      �� -
   5        
���   �
���   ����	#DDFFFFFF.��5�   4   OK5�      5�      �� 5�      -   5        $��_SIMNOT��5�      $	��0,5q�5�      $��Center=�5�      $ 
Horizontal=�5�      $y�	Collapsed=�5�      .+�5�      �� -   5        ���	#FF0CFF00���	#FF17FF00���	#DDFFFFFF.��5�   4   SIM5�      �� 5�      -   5        $��btn_Not��5�      $��5,0,0,0q�5�      
���  ��
���  �����	#DDFFFFFF.��5�   4   NÃO5�      5�      5�      5�      5�      5�      5�      