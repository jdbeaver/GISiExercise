   M S B A M L   `   `   `  ����  GSIiExercise_WPF3    -GSIiExercise_WPF.ViewModel.NormalizeLongitude   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  NormalizeLongitude��5   	   $	��155��6$   $	��380��61   .��5      � .+�5   
   �� -   5        $��normalizeButton��5      $��Find Normalized Longitude��6(   $
��Left=�6|   $��
160,26,0,0q�6�   $	��Top=�6�   $	��162��6�   ��6L   �� *NormalizeButtonClickCommand+6�   �� 5   
   $9��3(enter longitude in decimal degrees. e.g.: -220.55)��6   $
��Left=�6N   $��	24,54,0,0q�6i   $	��Top=�6|   �� 5   
   -   5        $��inputLonValue��5      $
��Left=�6}   $��23��6�   $��	26,26,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6(   �� *LonValue.InputLon+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5	   
   -   5        $��outputLonValue��5	      $
��Left=�6   $��	22,82,0,0q�6�   $	��Top=�6�   $	��291��6�   ��6&   �� *LonValue.OutputLon+$ TwoWay=�$ PropertyChanged=�6�   5      5      