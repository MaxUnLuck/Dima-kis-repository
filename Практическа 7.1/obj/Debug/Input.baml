   M S B A M L   `   `   `  ����U  QПрактическа 7.1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Практическа_7._1Практическа_7._1  5   	   '    !Практическа_7._1.Input   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Практическа_7._1     5   	     � Title$  Input��5   	   $	��450��6   $	��800��6$    � 
ResizeMode$ NoResize=�60   .��5	      � ��5
   
   �� 5       �� ImageSource$ /i (1).webp��6   .+�5   
   �� -   5         ��Name$
 Calc��5      $�� ��6   $
��Left=�6*   $��474,275,0,0q�6E   $	��Top=�6Z   $��90��6r   $��94��6~   $(��"Segoe UI Variable Display Semibold)�6�   $��1,1,1,1q�6�   ��5      �� 5      ��5      �� 5      $  /icons8-calculator-100.png��6   5      �� 5   
   $
��Calc��6   $
��Left=�6   $��495,261,0,0q�6:   $	��Top=�6O   $��52��6g   $��20(�6r   $
��Bold"�6�   �� 5   
   -   5         ��Name$ CalcTB��5      $
��Left=�6"   $��77��6=   $��354,135,0,0q�6I    �� TextWrapping$
 Wrap=�6^   $��TextBox��6r   $	��Top=�6�   $	��205��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   .��6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -26.356Q�6&   T� 5      5      .��5   '   5      �� 5    
   -   5        $ Num1TextBox��5       $
��Left=�6'   $��31��6B   $��
151,54,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��101��6�   $ 0.5,0.5&�6�   .��6�   z�5!      V� 5"      .~�5#      �� �� 5$      �� 5%      $ 12.554Q�6&   T� 5&      5'      .��5(   '   5)      �� 5*   
   -   5        $ Num2TextBox��5*      $
��Left=�6'   $��31��6B   $��193,111,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��101��6�   $ 0.5,0.5&�6�   .��6�   z�5+      V� 5,      .~�5-      �� �� 5.      �� 5/      $ 13.456Q�6&   T� 50      51      .��52   '   53      �� 54   
   $��Введите числа��6   $
��Left=�6(   $��43��6C   $��	240,0,0,0q�6O   $	��Top=�6b   $	��302��6z   $��20(�6�   �� 55   
   $
��Num1��6   $
��Left=�6   $��40��6:   $��
162,13,0,0q�6F   $	��Top=�6Z   $��80��6r   $ 0.5,0.5&�6}   $��18(�6�   z�56      V� 57      .~�58      �� �� 59      �� 5:      $ 13.048Q�6&   T� 5;      5<      5>      �� 5?   
   $
��Num2��6   $
��Left=�6   $��29��6:   $��238,139,0,0q�6F   $	��Top=�6[   $��80��6s   $ 0.5,0.5&�6~   $��18(�6�   z�5@      V� 5A      .~�5B      �� �� 5C      �� 5D      $ 12.976Q�6&   T� 5E      5F      5H      	� 5I   
   -   5         	�Name$ Division��5I      $��Division��6(   $
��Left=�6;   $��28��6V   $��	0,261,0,0q�6b   $	��Top=�6u   $	��133��6�   $��16(�6�   6�   	� 5J   
   -   5        $ 
Comparison��5J      $��
Comparison��6*   $
��Left=�6?   $��28��6Z   $��	0,287,0,0q�6f   $	��Top=�6y   $	��133��6�   $��16(�6�   	� 5K   
   -   5        $ Composition��5K      $��Composition��6+   $
��Left=�6A   $��22��6\   $��	0,232,0,0q�6h   $	��Top=�6{   $	��116��6�   $��16(�6�   6�   	� 5L   
   -   5        $ Rounding��5L      $��Rounding��6(   $
��Left=�6;   $��28��6V   $��	0,320,0,0q�6b   $	��Top=�6u   $	��133��6�   $��16(�6�   �� 5M   
   -	   5        $
��Exit��5M      $
��Left=�6    $��49��6;   $	��Top=�6G   $��75��6_   6j   5O      5P      