   M S B A M L   `   `   `  ����B  >Jupiter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Jupiter.Views.PagesJupiter.Views.Pages  5      1    +Jupiter.Views.Pages.PageVerificarPagamentos   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Jupiter.Views.Pages     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        N� Title$  PageVerificarPagamentos��5	      $	��850��5
      $	��530��5      $��Stretch=�5      $��Stretch=�5       N� 
Background
 ����� � Language$ pt-PT�5       � 	Resources 5         Storyboard1 �� 
TargetName �� TargetProperty9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value   EasingFunction.  (System.Windows.Media.Animation.CubicEase7  1System.Windows.Media.Animation.EasingFunctionBase	   
EasingMode��%�  &	        �� 5   
   .��5      U� $ detalhes��6,   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6M   .\�5        $ 0��6'   $ 0Q�63    5        5      $	 	EaseInOut=�6$   5        5      $ 0:0:1��6'   $ 1Q�67    5        5      $	 	EaseInOut=�6$   5      5      U� 5      $ detalhes��6,   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6M   .\�5         $ 0��6'   $ 0Q�63    5!        5"      $	 	EaseInOut=�6$   5$        5%      $ 0:0:1��6'   $ 1Q�67    5&        5'      $	 	EaseInOut=�6$   5)      5*      5+      5,      
 � Triggers
 5-      :� 5.   
    :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5/      �� #��[  6   50      .��52      � .+�53   
   �� $	��250��54      $��Stretch=�55      $	��Top=�56      ��57      �� 58       �� ImageSource$- '/Jupiter;component/Assets/blacfundo.jpg��6    j� Stretch$ UniformToFill=�6S   ._�5:      � .+�5;      � ���	#3F0000006   �� 5<      -   5        $��detalhes��5=      $
��50,0q�5>      $��Center=�5?      $��Center=�5@       J� RenderTransformOrigin$ 0.5,0.5&�5A      $y�	Collapsed=�5B      z�5C      V� 5D      .~�5E      �� �� 5F      �� 5G      T� 5H      5I      .+�5K      �� -   5        $��_date��5L      $��0,0,0,10q�5M      $��Center=�5N      $��25(�5O      
�������$��22 de outobro 2023��5Q      �� 5R      $��Center=�5S      $��Center=�5T      $��20(�5U      $
��Bold"�5V      
��������� 5X      -   5         �Name$ _total��5X      .�6,   50061    '  !MaterialDesignThemes.Wpf.PackIcon  5Y      $��20��5Z      $��20��5[      �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ Users=�5\      5]      �� 5^      -   5        $��_statos��5_      $
��0,10q�5`      $��Center=�5a      $��Bottom=�5b      $��16(�5c      
�������$��Que não pagaram��5e      5g      5h      5i      �� 5j   
   -   5        $��listaDia��5k      $��
0,250,0,20q�5l      $��Stretch=�5m      $��Center=�5n      $��Stretch=�5o      $��Disabled=�5p       �� View 5r      �� 5s      .P�5t      �� $��NOME DO ALUNO��6K    �� DisplayMemberBinding 6%   �� *Nome+6K   �� 5u      $��CLASSE��6M    6%   �� *Classe+6M   �� 5v      $	��Nº��6M    6%   �� *Numero+6M   �� 5w      $
��SALA��6K    6%   �� *Sala+6K   �� 5x      $��TURMA��6L    6%   �� *Turma+6L   5y      5{      )  #MaterialDesignThemes.Wpf.DialogHost  5|   
   -   5        $��modal��5}      $��Stretch=�5~      $��Stretch=�5         CloseOnClickAway .    IsOpen .     DialogContent 5�      � 5�      .+�5�      (  "MaterialDesignThemes.Wpf.ColorZone  $	��250��5�      $
��16,1q�5�      +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�5�      
����������	#DD000000.��5�      ��  �� Padding$ 10q�6!   ._�5�      �� .+�5�   "   ��  �� Orientation$ Vertical=�6-   .+�5�   &   �� $��Center=�60   $��16(�6M   ANALISAR PAGAMENTOS5�   '   �� 5�   &   -   5        $��
_anoLetivo��5�   )   $	��0,5q�5�   )   )	  #MaterialDesignThemes.Wpf.HintAssist 	  Hint$ 
Ano Letivo��5�   )    	  
IsFloating . ���	#89000000 �� 
CaretBrush
 �   ����	#DD000000 �� 	MaxLength$ 4��5�   )   5�   )   �� 5�   &   -   5        $��
listaMeses��5�   )   $��Bottom=�5�   )   $
 Mês��5�   )    . ���	#89000000���	#DD0000005�   )   �� 5�   &   -	   5        $��listaClasses��5�   )   $��Bottom=�5�   )   $ Classe��5�   )    . ���	#89000000���	#DD0000005�   )   �� 5�   &   -
   5        $��
listaSalas��5�   )   $��Bottom=�5�   )   $
 Sala��5�   )    . ���	#89000000���	#DD0000005�   )   �� 5�   &   -   5        $��listaTurmas��5�   )   $��Bottom=�5�   )   $ Turma��5�   )    . ���	#89000000���	#DD0000005�   )   �� 5�   &   -   5        $
��tipo��5�   )   $	��0,5q�5�   )   $��Bottom=�5�   )   $ 	Verificar��5�   )    . ���	#89000000���	#DD000000 �� SelectedIndex$ 1��5�   )   .@�5�   *   �� .��67   
Pagantes5�   +   �� 5�   *   .��67   	Devedores5�   +   5�   '   �� 5�   &   -   5        $
��0,10q�5�   )   ���	#DDFFFFFF.��5�   @   
Analisar5�   '   5�   #   5�      5�      5�      5�      5�      �� 5�   
   -   5        $��_btn_open_modal��5�      $��40��5�      $��40��5�      $��20q�5�      $��4q�5�      $��Right=�5�      $��Bottom=�5�      
���   �
������� & "MaterialDesignFloatingActionButton#���  5�       � ToolTip$ Verificar aluno��5�       ^� 	Placement$ Right=�5�      ��5�      Z� .��5�        $��16��5�      $��16��5�      $ Calendar=�5�      5�      5�      5�      