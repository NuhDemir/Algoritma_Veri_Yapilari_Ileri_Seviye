package SelectionSortSwingApp;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Arrays;
import java.util.Random;

public class SelectionSortVisualizer extends JPanel {
    private static final int WIDTH = 900;
    private static final int HEIGHT = 400;
    private static final int BAR_WIDTH = 30;
    private int[] array;
    private int currentIndex = 0;
    private int minIndex = 0;
    private int step = 0;
    private Timer timer;
    private JTextArea explanationArea;
    private String algorithm;

    public SelectionSortVisualizer(String algorithm) {
        this.algorithm = algorithm;
        setPreferredSize(new Dimension(WIDTH, HEIGHT));
        setBackground(new Color(0x444B6E));
        setLayout(new BorderLayout());

        // Açıklama metni için JTextArea oluştur
        explanationArea = new JTextArea();
        explanationArea.setEditable(false);
        explanationArea.setPreferredSize(new Dimension(300, HEIGHT));
        explanationArea.setBorder(BorderFactory.createEmptyBorder(10, 10, 10, 10));
        explanationArea.setBackground(new Color(0x9AB87A));
        explanationArea.setForeground(Color.BLACK);
        add(explanationArea, BorderLayout.EAST);

        // Zamanlayıcıyı oluştur
        timer = new Timer(500, new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                step();
                repaint();
                updateExplanation();
            }
        });
    }

    public void reset() {
        currentIndex = 0;
        minIndex = 0;
        step = 0;
        updateExplanation();
        repaint();
    }

    public void generateRandomArray(int length) {
        array = new int[length];
        Random rand = new Random();
        for (int i = 0; i < length; i++) {
            array[i] = rand.nextInt(100) + 1; // 1 ile 100 arasında rastgele sayılar
        }
        reset();
    }

    public void startSorting() {
        if (array == null || array.length == 0) {
            JOptionPane.showMessageDialog(this, "Dizi boş veya tanımlanmamış!", "Hata", JOptionPane.ERROR_MESSAGE);
            return;
        }
        timer.start();
    }

    private void step() {
        switch (algorithm) {
            case "Selection Sort":
                selectionSortStep();
                break;
            case "Bubble Sort":
                bubbleSortStep();
                break;
            case "Insertion Sort":
                insertionSortStep();
                break;
            case "Quick Sort":
                quickSortStep();
                break;
            case "Merge Sort":
                mergeSortStep();
                break;
            case "Heap Sort":
                heapSortStep();
                break;
            default:
                timer.stop();
        }
    }

    private void selectionSortStep() {
        if (currentIndex < array.length - 1) {
            if (step == 0) {
                minIndex = currentIndex;
                step++;
            } else if (step == 1) {
                for (int i = currentIndex + 1; i < array.length; i++) {
                    if (array[i] < array[minIndex]) {
                        minIndex = i;
                    }
                }
                step++;
            } else if (step == 2) {
                int temp = array[minIndex];
                array[minIndex] = array[currentIndex];
                array[currentIndex] = temp;
                currentIndex++;
                step = 0;
            }
        } else {
            timer.stop();
        }
    }

    private void bubbleSortStep() {
        // Bubble sort adım uygulaması
        // Adım adım görselleştirmek için bubble sort algoritması kodu
    }

    private void insertionSortStep() {
        // Insertion sort adım uygulaması
        // Adım adım görselleştirmek için insertion sort algoritması kodu
    }

    private void quickSortStep() {
        // Quick sort adım uygulaması
        // Adım adım görselleştirmek için quick sort algoritması kodu
    }

    private void mergeSortStep() {
        // Merge sort adım uygulaması
        // Adım adım görselleştirmek için merge sort algoritması kodu
    }

    private void heapSortStep() {
        // Heap sort adım uygulaması
        // Adım adım görselleştirmek için heap sort algoritması kodu
    }

    private void updateExplanation() {
        StringBuilder explanation = new StringBuilder();
        explanation.append("Adım: ").append(currentIndex + 1).append("\n");

        if (algorithm.equals("Selection Sort")) {
            if (step == 0) {
                explanation.append("En küçük elemanı bulmak için başla.\n");
            } else if (step == 1) {
                explanation.append("Kalan diziyi tarayıp en küçük elemanı bul.\n");
            } else if (step == 2) {
                explanation.append("Bulduğun en küçük elemanı şu anki elemanla yer değiştir.\n");
            }
        } else if (algorithm.equals("Bubble Sort")) {
            // Bubble sort açıklamaları
        } else if (algorithm.equals("Insertion Sort")) {
            // Insertion sort açıklamaları
        } else if (algorithm.equals("Quick Sort")) {
            // Quick sort açıklamaları
        } else if (algorithm.equals("Merge Sort")) {
            // Merge sort açıklamaları
        } else if (algorithm.equals("Heap Sort")) {
            // Heap sort açıklamaları
        }

        explanation.append("\nDizi Durumu:\n");
        for (int i = 0; i < array.length; i++) {
            explanation.append(array[i]).append(" ");
        }
        explanationArea.setText(explanation.toString());
    }

    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        if (array != null) {
            drawArray(g);
        }
    }

    private void drawArray(Graphics g) {
        Graphics2D g2d = (Graphics2D) g;
        for (int i = 0; i < array.length; i++) {
            if (i == currentIndex) {
                g2d.setColor(new Color(0x708B75)); // Geçerli eleman rengi
            } else if (i == minIndex) {
                g2d.setColor(new Color(0x3D315B)); // Minimum eleman rengi
            } else {
                g2d.setColor(new Color(0xF8F991)); // Diğer eleman rengi
            }
            g2d.fillRect(i * BAR_WIDTH, HEIGHT - array[i] * 3, BAR_WIDTH - 2, array[i] * 3);
        }
    }
}
