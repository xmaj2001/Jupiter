   M S B A M L   `   `   `  ����B  >Jupiter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Jupiter.Views.ModalJupiter.Views.Modal  5      $    Jupiter.Views.Modal.ModalAluno   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Jupiter.Views.Modal     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      -   5        $	��700��5	      $	��470��5
        � AllowsTransparency  .    MaterialDesignFont#���   5       � Language$ pt-PT�5      $��13(�5      $��Regular"�5        MaterialDesignBody#���  5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      ��5      Z�  � 	Resources 5        Storyboard1 �� 
TargetName �� TargetProperty9  3System.Windows.Media.Animation.EasingDoubleKeyFrame	 O� KeyTime
 O� Value   EasingFunction0  *System.Windows.Media.Animation.QuinticEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode  sair��%�  &	       &	 �    �� 5   
   .��5      U� $ 	_ViewMain��6,   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6N   .\�5        $	 0��6'   $
 0Q�63    5        5      $ EaseOut=�6&   5        5       $	 0:0:0.7��6'   $
 1Q�69    5!        5"      $ EaseOut=�6&   5$      5%      U� 5&      $ 	_ViewMain��6,   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6N   .\�5'        $	 0��6'   $
 0Q�63    5(        5)      $ EaseOut=�6&   5+        5,      $	 0:0:0.7��6'   $
 1Q�69    5-        5.      $ EaseOut=�6&   50      51      52      �� 53   
   .��54      U� $ 	_ViewMain��6,   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6N   .\�55        $	 0��6'   $
 1Q�63    56        57      $ EaseOut=�6&   59        5:      $	 0:0:0.5��6'   $
 0Q�69    5;        5<      $ EaseOut=�6&   5>      5?      U� 5@      $ 	_ViewMain��6,   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6N   .\�5A        $	 0��6'   $
 1Q�63    5B        5C      $ EaseOut=�6&   5E        5F      $	 0:0:0.5��6'   $
 0Q�69    5G        5H      $ EaseOut=�6&   5J      5K      5L      5M       � Triggers 5N      :� 5O   
    :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5P      �� #��[ 6   5Q      :� 5R   
   $ ButtonBase.Click��6    :� 
SourceName$ 	btn_close��66   .[�5S      �� -   5         ��Name$ sair_BeginStoryboard��5S      #��[ 6<   5T      .��5W      #  MaterialDesignThemes.Wpf.Card  -   5        $��	_ViewMain��5X   	   $��Stretch=�5Y   	    J� RenderTransformOrigin$ 0.5,0.5&�5[   	   z�5\   
   V� 5]      .~�5^      �� �� 5_      �� 5`      T� 5a      5b      .��5d   
   � -   5         �Name$
 grid��5d      $ 0.5,0.5&�6   z�5e      V� 5f      .~�5g      �� �� 5h      �� 5i      T� 5j      5k       � ColumnDefinitions 5m      �� 5n      $	��300 �6#   �� 5o      $��* �6#   .+�5q        -   5        $��Stretch=�5r       K� ZIndex$	 500��5s       J� 	AllowDrop . ��5u      Z� .��5w      � ��5x      �� 5y       j� Stretch$ UniformToFill=�6o    �� ImageSource 6%   ��  �� ElementName$ btn_foto�� �� Path$ Background.ImageSource�6o   .+�5{      � ��5|      �� 5}       �� 
StartPoint$ 0.5,0&�62    �� EndPoint$ 0.5,1&�6E   .��5~   "   �  � Offset$ 0Q�6/    � Color$ 	#59054946��6:   � 5   "   $ 1Q�6/   $ 	#B2000A09��6:   5�      5�      �� 5�      $��10q�5�      $
��Left=�5�      $	��Top=�5�      
�������$y�	Collapsed=�5�      ��5�      Z� ��5�      Z� .��5�      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ Restore=�62   5�      �� 5�      $��Center=�6!   $��Center=�6>   .+�5�      �� -   5        $��btn_foto��5�      $	��200��5�      $	��200��5�      $��Center=�5�      $��Center=�5�      ���	#FF00F3FF$��1q�5�       & "MaterialDesignFloatingActionButton#���  5�      ��5�      �� 5�   "   $ Uniform=�6J    6-   �� *Foto+6J   5�      �� 5�      $	��200��5�      $
��0,10q�5�      $��Center=�5�      $��16(�5�      
������� �� TextAlignment$ Center=�5�      $
��Wrap=�5�      ��5�      �� $ _nome��$
 Text�5�      5�      5�      5�      �� 5�      -   5        $��1��5�       . 
����� �$��1q�5�      ._�5�      � 
�������.+�5�      �� $	��200��5�      $��Center=�5�      $��Center=�5�      .+�5�      �� -   5        $��_titulo��5�      $��20(�5�      ���	#DD000000$ Center=�5�      Registrar Aluno5�      �� 5�      -	   5        $��_nome��5�      $	��200��5�      $��0,10,0,0q�5�      )  #MaterialDesignThemes.Wpf.HintAssist    Hint$  Nome do aluno��5�      !   
IsFloating! . .	  (MaterialDesignThemes.Wpf.TextFieldAssist" 	  UnderlineBrush
" �   ����	#89000000# �� 
CaretBrush
# �   ����	#DD000000$ �� SelectionBrush
$ �   �% �� 	IsEnabled% . 5�      � 5�      .+�5�      �� -
   5        $��_numero��5�   !   $	��200��5�   !   $��0,0,0,0q�5�   !   $	  Nº��5�   !   ! . 
" �   ����	#89000000
# �   ����	#DD000000
$ �   �5�   !   �� 5�      -   5        $��_gerarNumero��5�   !   $��30��5�   !   $��0q�5�   !   $��Right=�5�   !   ���	#FF686868$y�	Collapsed=�5�   !   ��5�   !   Z� ��5�   !   Z� .��5�   "     $ Numbers=�6:   5�      5�      �� 5�      -   5        $��_Classes��5�      $	��0,5q�5�      $  Classe��5�      ! . & �� 
IsEditable& . ' �� SelectedIndex$' 0��5�      �� 5�      -   5        $��_Sala��5�      $��0q�5�      $
  Sala��5�      ! . & . $' 0��5�      �� 5�      -   5        $��_Turma��5�      $	��0,5q�5�      $  Turma��5�      ! . 5�      �� 5�      -   5        $
��_ano��5�      $	��0,5q�5�      $  
Ano letivo��5�      ! . ( �� 	MaxLength$( 4��5�      5�      �� 5      -   5        $��
btn_action��5     $
��0,20q�5     $��Center=�5     ���	#FF00F3FF
���   �
�������.��5  0   Criar5	     5
     �� 5     -   5        $��	btn_close��5     $��10q�5     $��Right=�5     $	��Top=�5     
������ ���	#89000000$��0q�5     
���   �.��5       $ WindowClose=�62   5     5     5     5     5     5     