   M S B A M L   `   `   `  ����B  >Jupiter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Jupiter.Views.PagesJupiter.Views.Pages  5      &     Jupiter.Views.Pages.PageDiaTotal   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Jupiter.Views.Pages     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      -   5          N� Title$(  "Lista de Pagamento feito neste dia��5	      $	��850��5
      $	��530��5      $��Stretch=�5      $��Stretch=�5       N� 
Background
 ����� � Language$ pt-PT�5       � 	Resources 5         Storyboard1 �� 
TargetName �� TargetProperty9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value   EasingFunction.  (System.Windows.Media.Animation.CubicEase7  1System.Windows.Media.Animation.EasingFunctionBase	   
EasingMode/  )System.Windows.Media.Animation.CircleEase-  'System.Windows.Media.Animation.BackEase��%!  &	        �� 5   
   .��5      U� $ 
stackPanel��6,   $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6O   .\�5        $ 0��6'   $
 -100Q�63    5        5      $	 	EaseInOut=�6$   5        5      $ 0:0:1��6'   $ 0Q�67    5        5      $	 	EaseInOut=�6$   5      5      U� 5       $ 
stackPanel��6,   $ (UIElement.Opacity)�6O   .\�5!        $ 0��6'   $	 0.1Q�63    5"        5#      $	 EaseIn=�6%   5%        5&      $ 0:0:1��6'   $ 1Q�67    5'        5(      $	 EaseIn=�6%   5*      5+      U� 5,      $ btn_back��6,   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6M   .\�5-        $ 0��6'   $ 0Q�63    5.        5/      $	 EaseOut=�6#   51        52      $ 0:0:1��6'   $ 1Q�67    53        54      $	 EaseOut=�6#   56      57      U� 58      $ btn_back��6,   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6M   .\�59        $ 0��6'   $ 0Q�63    5:        5;      $	 EaseOut=�6#   5=        5>      $ 0:0:1��6'   $ 1Q�67    5?        5@      $	 EaseOut=�6#   5B      5C      5D      5E      
 � Triggers
 5F      :� 5G   
    :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5H      �� #��[  6   5I      .��5K      � .+�5L   
   �� $	��250��5M      $��Stretch=�5N      $	��Top=�5O      ��5P      �� 5Q       �� ImageSource$- '/Jupiter;component/Assets/blacfundo.jpg��6    j� Stretch$ UniformToFill=�6S   ._�5S      � .+�5T      � ���	#3F0000006   �� 5U      -   5        $��btn_back��5V      $
��20,5q�5W      $
��Left=�5X      $	��Top=�5Y      
���   �
���   ����	#DDFFFFFF J� RenderTransformOrigin$ 0.5,0.5&�5^      z�5_      V� 5`      .~�5a      �� �� 5b      �� 5c      T� 5d      5e      .��5g      ��  �� Orientation$ 
Horizontal=�6!   .+�5h      '  !MaterialDesignThemes.Wpf.PackIcon  $��Center=�62   �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ 	ArrowBack=�6M   �� 5i      Voltar6,   5j      5k      �� 5l      -   5         ��Name$ 
stackPanel��5m      $��50,5,0,0q�5n      $
��Left=�5o      $��Center=�5p      $ 0.5,0.5&�5q      z�5r      V� 5s      .~�5t      �� �� 5u      �� 5v      T� 5w      5x      .+�5z      �� $
��0,10q�5{      $��35(�5|      $
��Bold"�5}      
�������TOTAL DO DIA5�      �� 5�      -   5        $��_date��5�      $��	10,0,0,10q�5�      $��16(�5�      
�������5�      �� 5�      -   5        $��totaldia��5�      $��10,0,0,0q�5�      $��30(�5�      
�������$��0,00 Kz��5�      �� 5�      -   5        $��_total��5�      $��
10,10,0,10q�5�      $��16(�5�      
��������� 5�      $�Total de Pagamento��6    �� 5�      -   5         �Name$ _alunos��5�      $
��Bold"�5�      $�0��5�      5�      5�      �� 5�      -   5        $��gerarPDF��5�      $��40q�5�      $��0q�5�      $��Right=�5�      $	��Top=�5�      ���	#FF0A0909���	#DDFFFFFF * &MaterialDesignFloatingActionMiniButton#���  5�      ��5�      Z� .��5�        $ FilePdf=�6.   5�      5�      5�      �� 5�   
   -	   5        $��listaDia��5�      $��
0,250,0,20q�5�      $��Stretch=�5�      $��Center=�5�      $��Stretch=�5�      $��Disabled=�5�       �� View 5�      �� 5�      .P�5�      �� $��NOME DO ALUNO��6P    �� DisplayMemberBinding 6%   �� *	NomeAluno+6P   �� 5�      $��CLASSE��6M    6%   �� *Classe+6M   �� 5�      $��	MÊS PAGO��6^    6%   �� *Data+ �� StringFormat$
 MMMM��6^   �� 5�      $��VALOR DA PROPINA��6v    6%   �� *	Propina+$ C�� �� ConverterCulture$ pt-AO��6v   �� 5�      $��VALOR DA MULTA��6t    6%   �� *Multa+$ C��$ pt-AO��6t   �� 5�      $��TOTAL��6t    6%   �� *Total+$ C��$ pt-AO��6t   5�      5�      5�      5�      