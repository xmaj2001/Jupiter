   M S B A M L   `   `   `  ����B  >Jupiter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Jupiter.Views.PagesJupiter.Views.Pages  5      $    Jupiter.Views.Pages.PageConfig   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Jupiter.Views.Pages     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        N� Title$  
PageConfig��5	      $��Stretch=�5
      $��Stretch=�5       N� 
Background
 ����� � 	Resources 5         Storyboard1 �� 
TargetName �� TargetProperty9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value   EasingFunction.  (System.Windows.Media.Animation.CubicEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode/  )System.Windows.Media.Animation.CircleEase-  'System.Windows.Media.Animation.BackEase��%t  &	        �� 5   
   .��5      U� $ 
stackPanel��6,   $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6O   .\�5        $ 0��6'   $ 75Q�63    5        5      $ 	EaseInOut=�6$   5        5      $ 0:0:1��6'   $ 0Q�67    5        5      $ 	EaseInOut=�6$   5      5      U� 5      $ 
stackPanel��6,   $ (UIElement.Opacity)�6O   .\�5        $ 0��6'   $	 0.1Q�63    5        5      $ EaseIn=�6$   5!        5"      $ 0:0:1��6'   $ 1Q�67    5#        5$      $ EaseIn=�6$   5&      5'      U� 5(      $ 	textBlock��6,   $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6N   .\�5)        $ 0��6'   $
 -100Q�63    5*        5+      $ 	EaseInOut=�6$   5-        5.      $ 0:0:0.9��6'   $ 0Q�69    5/        50      $ 	EaseInOut=�6$   52      53      U� 54      $ 	textBlock��6,   $ (UIElement.Opacity)�6N   .\�55        $ 0��6'   $	 0.1Q�63    56        57      $ EaseIn=�6%   59        5:      $ 0:0:0.9��6'   $ 1Q�69    5;        5<      $ EaseIn=�6%   5>      5?      U� 5@      $ packIcon��6,   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6M   .\�5A        $ 0��6'   $	 0.5Q�63    5B        5C      $ EaseOut=�6#   5E        5F      $ 0:0:1��6'   $ 1Q�67    5G        5H      $ EaseOut=�6#   5J      5K      U� 5L      $ packIcon��6,   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6M   .\�5M        $ 0��6'   $	 0.5Q�63    5N        5O      $ EaseOut=�6#   5Q        5R      $ 0:0:1��6'   $ 1Q�67    5S        5T      $ EaseOut=�6#   5V      5W      U� 5X      $ listaDia��6,   $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6M   .\�5Y        $ 0��6'   $	 100Q�63    5Z        5[      $ 	EaseInOut=�6$   5]        5^      $ 0:0:1��6'   $ 0Q�67    5_        5`      $ 	EaseInOut=�6$   5b      5c      U� 5d      $ stackPanel1��6,   $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6P   .\�5e        $ 0��6'   $	 100Q�63     5f      $ 0:0:1��6'   $ 0Q�67   5g      U� 5h      $ listaDia��6,   $ (UIElement.Opacity)�6M   .\�5i        $ 0��6'   $	 0.1Q�63    5j        5k      $ EaseOut=�6%   5m        5n      $ 0:0:1��6'   $ 1Q�67    5o        5p      $ EaseOut=�6%   5r      5s      U� 5t      $ stackPanel1��6,   $ (UIElement.Opacity)�6P   .\�5u        $ 0��6'   $	 0.1Q�63     5v      $ 0:0:1��6'   $ 1Q�67   5w      5x      5y      	 � Triggers	 5z      :� 5{   
   
 :� RoutedEvent$
 FrameworkElement.Loaded��6   .[�5|      �� #��[  6   5}      .��5      � .+�5�   
   �� -   5        $��hittextSenha��5�      $��Digita a senha atual��5�      $y�	Collapsed=�5�      �� 5�   
   $��Stretch=�6   $��Stretch=�63   .+�5�      �� $	��250��5�      $��Stretch=�5�      $	��Top=�5�      ��5�      �� 5�       �� ImageSource$- '/Jupiter;component/Assets/blacfundo.jpg��6!    j� Stretch$ UniformToFill=�6W   ._�5�      � .+�5�      � ���	#3F0000006   '  !MaterialDesignThemes.Wpf.PackIcon  5�      -   5          Name$ packIcon��5�      $	��100��5�      $	��100��5�      $��100,50q�5�      $��Right=�5�      $	��Top=�5�      
��������  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ Settings=�5�       J� RenderTransformOrigin$ 0.5,0.5&�5�      z�5�      V� 5�      .~�5�   "   �� �� 5�   "   �� 5�   "   T� 5�   "   5�      5�      �� 5�      $��
50,-20,0,0q�5�      $
��Left=�5�      $��Center=�5�      .+�5�      �� -   5         ��Name$ 	textBlock��5�      $
��0,10q�5�      $��35(�5�      $
��Bold"�5�      
�������$ 0.5,0.5&�5�      z�5�      V� 5�   "   .~�5�   &   �� �� 5�   &   �� 5�   &   T� 5�   &   5�   #   Configurações5�      5�      5�      5�      �� 5�      -   5         ��Name$ 
stackPanel��5�      $��
0,-75,0,30q�5�      $��Center=�5�       �� Orientation$ 
Horizontal=�5�      $ 0.5,0.5&�5�      z�5�      V� 5�      .~�5�      �� �� 5�      �� 5�      T� 5�      5�      .+�5�      (  "MaterialDesignThemes.Wpf.ColorZone  $	��200��5�      $��70��5�      $
��40,0q�5�      $��8,4,8,4q�5�      $��Center=�5�       K� ZIndex$ 1��5�      +	  %MaterialDesignThemes.Wpf.ShadowAssist 	  ShadowDepth$ Depth1=�5�      
�������
�������   CornerRadius$ 4��5�      ���	#DD000000   Mode$ Standard=�5�       � ToolTip$ Produto de XMAJ��5�      .��5�      ��  �� Padding$ 10q�6   ._�5�      � .+�5�      �� 
���   � �� CornerRadius$ 4��68   �� 5�      $��Center=�6)   $ 
Horizontal=�6D   .+�5�   "     $��30��5�   %   $��30��5�   %   $��10,0,0,0q�5�   %   $��Center=�5�   %   
�������$ DeveloperBoard=�5�   %   �� 5�   "   $
��20,0q�6-   $��Center=�6;   .+�5�   &   �� $��10(�60   
�������XMAJ5�   '   5�   #   5�      5�      5�      5�      �� 5�      -   5        $	��150��5�      $	��150��5�      $��0q�5�      $��8,4,8,4q�5�      $��Center=�5�      $ Depth1=�5�       J� 	AllowDrop . 
�������
����������	#DD000000.��5�      �� -   5        $
��Logo��5�      $(��"/Jupiter;component/Assets/user.jpg��6(   5�        5�      $	��200��5�      $��70��5�      $
��50,0q�5      $��8,4,8,4q�5     $��Center=�5     $ 1��5     $ Depth1=�5     
�������
�������$ 4��5     ���	#DD000000$ Standard=�5	     .��5
     �� $ 10q�6   ._�5     � .+�5     �� 
���   �$ 4��68   �� 5     $��Center=�6)   $ 
Horizontal=�6D   .+�5  "     $��30��5  %   $��30��5  %   $��10,0,0,0q�5  %   $��Center=�5  %   
�������$ users=�5  %   �� 5  "   $
��20,0q�6-   $��Center=�6;   .+�5  &   �� $��10(�60   
�������Total de alunos5  '   �� 5  &   -   5        $��_totalalunos��5  0   
�������05  '   5  #   5     5     5     5      5!     � 5#     -   5        $��listaDia��5$     $	��300��5%     $��275,0q�5&     $��Center=�5'     $��Bottom=�5(     $ 0.5,0.5&�5)     z�5*     V� 5+     .~�5,     �� �� 5-     �� 5.     T� 5/     50     .+�52       $��16,35q�53     $��8,4,8,4q�54     $ 1��55     $ Depth1=�56     ���	#FF1E1E1E$ 2��58     ���	#DDFFFFFF$ Standard=�5:     .��5;     �  � ColumnDefinitions 5<     �� 5=     $
��Auto �6/   �� 5>     $
��356* �6/   �� 5?     $��40 �6/   �� 5@     $
��Auto �6/   .+�5B     �� 
�������  MaterialDesignToolButton#���  64   .��5C       
�������$ PasswordReset=�5E  !    J� Opacity$	 .56Q�5F  !   5G     G� 5H     -	   5        $��sh��5I     $��1��5J     $��2��5K     $	��200��5L     $��8,4,0,4q�5M     $��Center=�5N     .
  (MaterialDesignThemes.Wpf.TextFieldAssist 
  DecorationVisibility$ Hidden=�5P     ���	#89FFFFFF$��0q�5R      G� 
CaretBrush
 �����)  #MaterialDesignThemes.Wpf.HintAssist   Hint 5O     ��   �� ElementName$  hittextSenha��! �� Path$
! Text�5T     �� 5U     -
   5        $��btn_alterar��5V     $��2��5W     $
��Auto��5X     
�������#���  5[     .��5\       $
 Lock=�66   $	 .56Q�6B   5]     5^     5_     5`     �� 5b     -   5        $ stackPanel1��5c     $��Center=�5d     $ 0.5,0.5&�5e     z�5f     V� 5g     .~�5h     �� �� 5i     �� 5j     T� 5k     5l     .+�5n     �� $��0,0,0,10q�6   $��Center=�6.   	ESCOLAS5p     �� 5q     $��Center=�6   $ 
Horizontal=�6:   .+�5r     �� 
���   �&$ESCOLA PE LIBERMANN N° 1111-MAIANGA5t     d� 5u     -   5        $��Escola��5v     $
��10,0q�5w     
�������" d� 	IsChecked$
" TrueY�5{      ( $MaterialDesignSwitchDarkToggleButton#��[ 5|     �� 5}     
���   �$"ESCOLA PE.DANIEL BROTHIER N° 11265     5�     5�     5�     '  !MaterialDesignThemes.Wpf.Snackbar  5�  
   -   5        #  Name$# Snackbar��5�     $	��400��5�     $	��0,5q�5�     
���   �
���   �$   IsActive$ .  %   MessageQueue% 5�     4  .MaterialDesignThemes.Wpf.MessageQueueExtension  &   Message.& 5�     .  (MaterialDesignThemes.Wpf.SnackbarMessage  -   5        $��snackMS��5�     $ Depth1=�5�     '   ActionContent$' OK��5�     $��Hello 2��5�     
���   �5�     5�     5�     5�     