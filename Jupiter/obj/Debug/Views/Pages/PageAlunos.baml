   M S B A M L   `   `   `  ����B  >Jupiter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Jupiter.Views.PagesJupiter.Views.Pages  5      $    Jupiter.Views.Pages.PageAlunos   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Jupiter.Views.Pages     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      -   5          N� Title$  Lista de Alunos��5	      $	��850��5
      $	��530��5      $��Stretch=�5      $��Stretch=�5       N� 
Background
 ����� � 	Resources 5         Storyboard1 �� 
TargetName �� TargetProperty9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value   EasingFunction.  (System.Windows.Media.Animation.CubicEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode��%�  &	        �� 5   
   .��5      U� $ 	colorZone��6,   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6N   .\�5        $ 0��6'   $ 0Q�63    5        5      $ 	EaseInOut=�6$   5        5      $ 0:0:1��6'   $ 1Q�67    5        5      $ 	EaseInOut=�6$   5      5      U� 5      $ 	colorZone��6,   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6N   .\�5         $ 0��6'   $ 0Q�63    5!        5"      $ 	EaseInOut=�6$   5$        5%      $ 0:0:1��6'   $ 1Q�67    5&        5'      $ 	EaseInOut=�6$   5)      5*      5+      5,      	 � Triggers	 5-      :� 5.   
   
 :� RoutedEvent$
 FrameworkElement.Loaded��6   .[�5/      �� #��[  6   50      .��53      � .+�54   
   (  "MaterialDesignThemes.Wpf.ColorZone  -   5          Name$ 	colorZone��55      $��
20,10,20,0q�56      $��8,4,8,4q�57       K� ZIndex$ 1��58      +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�59         CornerRadius$ 2��5:         Mode$
 Dark=�5;       J� RenderTransformOrigin$ 0.5,0.5&�5<      z�5=      V� 5>      .~�5?      �� �� 5@      �� 5A      T� 5B      5C      .��5E      � -   5         �Name$
 grid��5E      $ 0.5,0.5&�6!   z�5F      V� 5G      .~�5H      �� �� 5I      �� 5J      T� 5K      5L       � ColumnDefinitions 5N      �� 5O      $
��Auto �6'   �� 5P      �� 5Q      $��40 �6'   �� 5R      $��40 �6'   .+�5T      �� $
��Auto��5U      $	��0,4q�5V      
�������  MaterialDesignToolButton#���  5X      .��5Y      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ Magnify=�6.    J� Opacity$	 .56Q�6=   5Z      �� 5[      $��1��5\      $��40��5]      $��8,0,0,0q�5^      $��Center=�5_       �� Orientation$ 
Horizontal=�5`      .+�5a      �� -   5        $��
_Pesquizar��5b      $	��460��5c      $��Center=�5d      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	Pesquisar��5e      .	  (MaterialDesignThemes.Wpf.TextFieldAssist 	  DecorationVisibility$ Hidden=�5f      $��0q�5g      5h      �� 5j      -   5        $��_Classes��5k      $	��100��5l      $
��10,0q�5m      $ Classe��5n      ���	#89FFFFFF$��0q�5p       �� SelectedIndex$ 0��5q       & "MaterialDesignFloatingHintComboBox#��[ 5s      �� 5u      -   5        $��textAno��5v      $ 
Ano Letivo��5w         
IsFloating . ���	#89FFFFFF$��0q�5z       �� 	MaxLength$ 4��5{      $
��2023��5}      5~      �� 5      -   5        $��_totalAlunos��5�      $��5,0,0,0q�5�      ���	#FF1B1B1C$��10(�5�      ���	#DDFFFFFF � ToolTip$ 	56 ALUNOS��5�      ��5�      Z� .��5�        $ Users=�62   5�      5�      �� 5�      -   5        $��btn_code��5�      $��2��5�      $
��Auto��5�      $	��0,4q�5�      $��4q�5�      
���   �
�������.��5�        $ BarcodeScan=�6.   5�      '
  !MaterialDesignThemes.Wpf.PopupBox
  5�      $��3��5�      $��0q�5�      $��Stretch=�5�      $��Center=�5�      $��Center=�5�      
������� 
  PlacementMode$ BottomAndAlignLeftEdges=�5�       
  PopupContent. 5�      �� -	   5        $��ListaCam��5�      $��10q�5�      $��10(�5�      5�      5�      5�      �� 5�   
   -
   5        $��_ListaAlunos��5�      $��	5,63,5,20q�5�      $��Stretch=�5�      $��Stretch=�5�      $��Disabled=�5�      ��5�      �� 5�      .R�5�      � $��Stretch=�6    $��Stretch=�6>   5�      ��5�      �� 5�      .R�5�      �� $	��120��5�      $	��150��5�       �� Padding$ 5q�5�      ���	#7FF1F1F1$��1q�5�       �� CornerRadius$ 4��5�      ._�5�      �� $��5q�6%   .+�5�      �� $��85��5�   !   $��85��5�   !   $��Stretch=�5�   !   $��Stretch=�5�   !   $	 100��5�   !   ��5�   "   �� 5�   &     j� Stretch$  UniformToFill=�6N   ! �� ImageSource! 61   �� *Foto+6N   5�      �� 5�      $��10(�5�   !   ���	#FF1B1B1C" �� TextAlignment$" Center=�5�   !   $
��Wrap=�5�   !   ��5�   !   �� *Nome+5�   !   5�      5�      5�      5�      �� 5�   
   -   5        $��_btn_add��5�      $��40��5�      $��40��5�      $��20q�5�      $��4q�5�      $��Right=�5�      $��Bottom=�5�      
���   �
������� & "MaterialDesignFloatingActionButton#���  5�      $ Adicionar Aluno��5�      # ^� 	Placement$# Right=�5�      ��5�      Z� .��5�        $��24��5�      $��24��5�      $
 Plus=�5�      5�      5�      5�      