   M S B A M L   `   `   `  ����B  >Jupiter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Jupiter.Views.ModalJupiter.Views.Modal  5      (    "Jupiter.Views.Modal.ModalViewAluno   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Jupiter.Views.Modal     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        � Title$  ModalViewAluno��5	      $	��600��5
      $	��370��5       � AllowsTransparency . 
������� � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      .��5      � -   5        .+�5   
   �� $��40��5      $	��Top=�5      ��5      ��  �� ElementName$ statos�� �� Path$ 
Foreground�._�5      � .+�5      �� -   5        $��	btn_close��5      $��40��5      $
��10,0q�5      $��4q�5      $��Right=�5      ���	#DDFFFFFF��5      Z� ��5      Z� .��5!      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ WindowClose=�6.   5"      �� 5#      -   5        $��Titulo��5$      $��Center=�5%      $��Center=�5&      $
��Bold"�5'      
�������VERIFICAR PAGAMENTO5*      5+      5,      �� 5.   
   $��0,15,0,0q�6    �� Orientation$ 
Horizontal=�6'   .+�5/      �� $��Center=�6   .+�50      �� -   5        $��p_foto��51      $	��200��52      $	��200��53      $��30,0,0,0q�54       J� RenderTransformOrigin$ 0.5,0.5&�56       *  &MaterialDesignFloatingActionMiniButton#���   57      ��55      �� $ statos��$ 
Foreground�z�58      V� 59      .~�5:      �� �� 5;      �� 5<      T� 5=      5>      ��5@      �� 5A      	 j� Stretch$	 Uniform=�6B   
 �� ImageSource
 6%   �� *Foto+6B   5C      5E      �� 5F      -   5         ��Name$ 
stackPanel��5G      $��50,0,0,0q�5H      $��Center=�5I      $ 0.5,0.5&�5J      z�5K      V� 5L      .~�5M      �� �� 5N      �� 5O      T� 5P      5Q      .+�5S      �� -   5        $��_nome��5T      $	��0,5q�5U      $��Pacifico)�5V      $��18(�5W      
���   ���5Y      �� *Nome+�� 5[      $��0q�6   $ 
Horizontal=�6(   .+�5\      �� 
�������Nº:5^      �� 5_      $��5,0,0,0q�5`       � Language$ pt-PT�5a      ��5b      �� *Numero+5c      �� 5e      $��0q�6   $ 
Horizontal=�6(   .+�5f      �� 
�������	Classe:5h      �� 5i      $��5,0,0,0q�6    $ pt-PT�61   �� 5j      �6   �� *Classe+ �� 5k      .�6   ª5m      5n      5o      �� 5p      $��0q�6   $ 
Horizontal=�6(   .+�5q      �� 
�������Sala:5s      �� 5t      $��5,0,0,0q�5u      $ pt-PT�5v      ��5w      �� *Sala+5x      �� 5y      $��0q�6   $ 
Horizontal=�6(   .+�5z      �� 
�������Turma:5|      �� 5}      $��5,0,0,0q�5~      $ pt-PT�5      ��5�      �� *Turma+5�      �� 5�      $	��0,5q�6   $ 
Horizontal=�6*   .+�5�      �� -   5        $��statos��5�      $
��Bold"�5�      
�������
Não Pagou5�      �� 5�      -   5        $��textMes��5�       $��5,0,0,0q�6/   O MÊS DE OUTOBRO 20235�      5�      �� 5�      $
��0,10q�6   $ 
Horizontal=�6+   .+�5�      �� -	   5        $��0,0,10,0q�5�      
���   �$��12(�5�      
���������5�      Z� .��5�   ,   Fechar5�      �� 5�      -
   5        $��btn_detlhes��5�      
���   �$��12(�5�      
���   ���5�      Z� .��5�   ,   Perfil5�      5�      5�      5�      5�      5�      