   M S B A M L   `   `   `  ����B  >Jupiter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Jupiter.Views.PagesJupiter.Views.Pages  5      *    $Jupiter.Views.Pages.PageHistoricoDia   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Jupiter.Views.Pages     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        N� Title$  Total do Dia��5	      $	��850��5
      $	��530��5      $��Stretch=�5      $��Stretch=�5       N� 
Background
 ����� � Language$ pt-PT�5       � 	Resources 5         Storyboard1 �� 
TargetName �� TargetProperty9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value   EasingFunction/  )System.Windows.Media.Animation.CircleEase7  1System.Windows.Media.Animation.EasingFunctionBase	   
EasingMode0  *System.Windows.Media.Animation.QuinticEase��%'  &	        �� 5   
   .��5      U� $ 
stackPanel��6,   $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6O   .\�5        $ 0��6'   $
 -100Q�63    5        5      $	 	EaseInOut=�6%   5        5      $ 0:0:1��6'   $ 0Q�67    5        5      $	 	EaseInOut=�6%   5      5      U� 5      $ 
stackPanel��6,   $ (UIElement.Opacity)�6O   .\�5         $ 0��6'   $	 0.1Q�63    5!        5"      $	 EaseIn=�6%   5$        5%      $ 0:0:1��6'   $ 1Q�67    5&        5'      $	 EaseIn=�6%   5)      5*      U� 5+      $ 	colorZone��6,   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6N   .\�5,        $ 0��6'   $	 0.5Q�63    5-        5.      $	 EaseOut=�6&   50        51      $ 0:0:1��6'   $ 1Q�67    52        53      $	 EaseOut=�6&   55      56      U� 57      $ 	colorZone��6,   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6N   .\�58        $ 0��6'   $	 0.5Q�63    59        5:      $	 EaseOut=�6&   5<        5=      $ 0:0:1��6'   $ 1Q�67    5>        5?      $	 EaseOut=�6&   5A      5B      5C      5D      
 � Triggers
 5E      :� 5F   
    :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5G      �� #��[  6   5H      .��5K      � .+�5L   
   �� $��Stretch=�6   $��Stretch=�63   .+�5M      �� $	��250��5N      $��Stretch=�5O      $	��Top=�5P      ��5Q      �� 5R       �� ImageSource$- '/Jupiter;component/Assets/blacfundo.jpg��6!    j� Stretch$ UniformToFill=�6W   ._�5T      � .+�5U      � ���	#3F0000006   �� 5V      -   5         ��Name$ 
stackPanel��5W      $��
50,-20,0,0q�5X      $
��Left=�5Y      $��Center=�5Z       J� RenderTransformOrigin$ 0.5,0.5&�5[      z�5\      V� 5]      .~�5^   "   �� �� 5_   "   �� 5`   "   T� 5a   "   5b      .+�5d      �� $
��0,10q�5e      $��35(�5f      $
��Bold"�5g      
�������TOTAL DO DIA5j      �� 5k      -   5        $��_date��5l      $��	10,0,0,10q�5m      $��16(�5n      
�������25 de Outubro de 20235q      �� 5s      -   5        $��totaldia��5t      $��10,0,0,0q�5u      $��30(�5v      
�������$��0,00 Kz��5x      5y      �� 5z      -   5        $��gerarPDF��5{      $��40q�5|      $��0q�5}      $��Right=�5~      $	��Top=�5      ���	#FF0A0909���	#DDFFFFFF * &MaterialDesignFloatingActionMiniButton#���  5�      ��5�      Z� .��5�      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ FilePdf=�62   5�      5�      5�      (  "MaterialDesignThemes.Wpf.ColorZone  5�      -   5          Name$ 	colorZone��5�      $��50,-15,50,10q�5�      $��8,4,8,4q�5�      $��Center=�5�       K� ZIndex$ 1��5�      +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�5�      
�������
�������   CornerRadius$ 2��5�      ���	#DD000000   Mode$ Standard=�5�      $ 0.5,0.5&�5�      z�5�      V� 5�      .~�5�      �� �� 5�      �� 5�      T� 5�      5�      .��5�      �  � ColumnDefinitions 5�      �� 5�      $
��Auto �6+   �� 5�      $
��356* �6+   �� 5�      $
��Auto �6+   .+�5�      �� 
���   �
���   �  MaterialDesignToolButton#���  5�      .��5�        $ Magnify=�62    J� Opacity$	 .56Q�6A   5�      (	  "System.Windows.Controls.DatePicker	  5�      -   5        $��pesquisarData��5�      $��1��5�      $��2��5�      $	��200��5�      $��8,4,0,4q�5�      $��Center=�5�      )
  #MaterialDesignThemes.Wpf.HintAssist 
  Hint$ Procurar Dia��5�      .  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�5�      ���	#33FFFFFF
���   �$��0q�5�      
���   �5�      5�      5�      5�      �� 5�   
   -   5        $��listaDia��5�      $��10,280,10,0q�5�      $��Stretch=�5�      $��Center=�5�      $��Stretch=�5�      $��Disabled=�5�      ��5�      �� 5�      .R�5�        $	��800��5�      $��10q�5�      $��Stretch=�5�      $��Stretch=�5�      $ 1��5�      $ Depth3=�5�      
���   �$ 4��5�      ���	#DDFFFFFF.��5�      ��  �� Orientation$ 
Horizontal=�6%   .+�5�      �� $��12(�6(   $��No dia ��66   �� 5�      $��12(�6(   ��66   �� *Dia+ �� StringFormat$ D���� 5�      $��12(�6(   $�� teve-se o total de ��66   �� 5�      $��12(�5�   !   $
��Bold"�5�   !   ��5�   !   �� *Total+$ C�� �� ConverterCulture$ pt-AO��5�      5�      5�      5�      5�      5�      