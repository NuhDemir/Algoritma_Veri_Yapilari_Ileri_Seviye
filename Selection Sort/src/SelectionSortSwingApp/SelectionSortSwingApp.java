package SelectionSortSwingApp;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class SelectionSortSwingApp {
    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            JFrame frame = new JFrame("Sıralama Algoritması Öğretici");
            frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
            frame.setSize(1200, 600);
            frame.setLayout(new BorderLayout());

            // Paneli ve bileşenleri oluştur
            JPanel inputPanel = new JPanel();
            inputPanel.setBackground(new Color(0xF8F991));
            inputPanel.setLayout(new FlowLayout());

            JLabel lengthLabel = new JLabel("Dizi Uzunluğu:");
            JTextField lengthField = new JTextField(5);

            // Algoritma seçim butonları
            JButton selectionSortButton = new JButton("Selection Sort");
            JButton quickSortButton = new JButton("Quick Sort");
            JButton mergeSortButton = new JButton("Merge Sort");
            JButton bubbleSortButton = new JButton("Bubble Sort");
            JButton insertionSortButton = new JButton("Insertion Sort");
            JButton heapSortButton = new JButton("Heap Sort");

            inputPanel.add(lengthLabel);
            inputPanel.add(lengthField);
            inputPanel.add(selectionSortButton);
            inputPanel.add(quickSortButton);
            inputPanel.add(mergeSortButton);
            inputPanel.add(bubbleSortButton);
            inputPanel.add(insertionSortButton);
            inputPanel.add(heapSortButton);

            frame.add(inputPanel, BorderLayout.NORTH);

            // Seçim butonlarına tıklanınca diziyi oluştur ve sıralama algoritmasını başlat
            ActionListener algorithmListener = new ActionListener() {
                @Override
                public void actionPerformed(ActionEvent e) {
                    try {
                        int length = Integer.parseInt(lengthField.getText());
                        if (length <= 0) {
                            JOptionPane.showMessageDialog(frame, "Dizi uzunluğu pozitif bir sayı olmalıdır.", "Hata", JOptionPane.ERROR_MESSAGE);
                            return;
                        }
                        JButton source = (JButton) e.getSource();
                        String algorithm = source.getText();

                        SelectionSortVisualizer visualizer = new SelectionSortVisualizer(algorithm);
                        frame.getContentPane().removeAll();
                        frame.add(inputPanel, BorderLayout.NORTH);
                        frame.add(visualizer, BorderLayout.CENTER);
                        frame.revalidate();
                        frame.repaint();

                        visualizer.generateRandomArray(length);
                        visualizer.startSorting();
                    } catch (NumberFormatException ex) {
                        JOptionPane.showMessageDialog(frame, "Lütfen geçerli bir sayı girin.", "Hata", JOptionPane.ERROR_MESSAGE);
                    }
                }
            };

            selectionSortButton.addActionListener(algorithmListener);
            quickSortButton.addActionListener(algorithmListener);
            mergeSortButton.addActionListener(algorithmListener);
            bubbleSortButton.addActionListener(algorithmListener);
            insertionSortButton.addActionListener(algorithmListener);
            heapSortButton.addActionListener(algorithmListener);

            frame.setVisible(true);
        });
    }
}
